using AnnouncementWebApi.Services;
using AutoMapper;
using Bogus.DataSets;
using Data.DTO;
using Data.Entities;
using FluentValidation;
using Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AnnouncementWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnnouncementController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILoggerService _logger;
        private readonly IValidator<Announcement> _validator;
        private readonly IMapper _mapper;

        public AnnouncementController(IUnitOfWork unitOfWork, ILoggerService logger,IMapper mapper, IValidator<Announcement> validator)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
            _validator = validator;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Announcement>>> GetAll()
        {
            var listOfAnnouncements = await _unitOfWork.Announcement.GetAllAsync();
            if (listOfAnnouncements == null)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetAll)}");
                return StatusCode(500, "Internal server error");
            }
            return Ok(listOfAnnouncements);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Announcement>>> GetByIdAndThreeSimilar(int id)
        {
            var announcement = await _unitOfWork.Announcement.GetByIdAsync(id);
            if (announcement == null)
            {
                _logger.LogInfo($"Announcement with id: {id} doesn't exist in the database.");
                return NotFound();
            }
            else
            {
                var listOfAnnoucements = await _unitOfWork.Announcement.GetAllAsync();
                var matches = listOfAnnoucements
                  .Select(ann =>
                  {
                      int count = 0;
                      foreach (var item in announcement.Title.Split(' '))
                      {
                          if (ann.Title.Contains(item))
                              count++;
                      }
                      return new { count, ann };

                  }).OrderByDescending(d => d.count).Where(x => x.count > 0)
                     .Select(w =>
                     {
                         int count = w.count;
                         foreach (var item in announcement.Description.Split(' '))
                         {
                             if (w.ann.Description.Contains(item))
                                 count++;
                         }
                         return new { count, w.ann };

                     }).OrderByDescending(d => d.count).Take(4);

                return Ok(matches); //returns announcement by id and 3 similar
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateAnnouncement([FromBody] CreateAnnouncementDTO announcementDto)
        {
            if (announcementDto == null)
            {
                _logger.LogError("CreateAnnouncementDto object sent from client is null.");
                return BadRequest("CreateAnnouncementDto object is null");
            }

            var result = await _validator.ValidateAsync(_mapper.Map<Announcement>(announcementDto));
            if (!result.IsValid)
            {
                var errorMessages = result.Errors.Select(x => x.ErrorMessage).ToList();
                return BadRequest(errorMessages);
            }

            _unitOfWork.Announcement.Create(_mapper.Map<Announcement>(announcementDto));
            await _unitOfWork.SaveAsync();

            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAnnouncement(int id,[FromBody]UpdateAnnouncementDTO updateAnnouncement)
        {
            if (updateAnnouncement == null)
            {
                _logger.LogError("UpdateAnnouncementDTO object sent from client is null.");
                return BadRequest("UpdateAnnouncementDTO object is null");
            }

            var result = await _validator.ValidateAsync(_mapper.Map<Announcement>(updateAnnouncement));
            if (!result.IsValid)
            {
                var errorMessages = result.Errors.Select(x => x.ErrorMessage).ToList();
                return BadRequest(errorMessages);
            } 

            var announcement = await _unitOfWork.Announcement.GetByIdAsync(id);
            if(announcement == null)
            {
                _logger.LogInfo($"Annoucement with id: {id} doesn't exist in the database.");
                return NotFound();
            }
            _unitOfWork.Announcement.Update(_mapper.Map(updateAnnouncement, announcement));
            await _unitOfWork.SaveAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnnouncement(int id)
        {
            var announcement = await _unitOfWork.Announcement.GetByIdAsync(id);
            if (announcement == null)
            {
                _logger.LogInfo($"Announcement with id: {id} doesn't exist in the database.");
                return NotFound();
            }
            _unitOfWork.Announcement.Delete(announcement);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
    }
}