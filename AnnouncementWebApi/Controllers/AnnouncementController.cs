using AnnouncementWebApi.Services;
using AutoMapper;
using Bogus.DataSets;
using Data.DTO;
using Data.Entities;
using Interfaces;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace AnnouncementWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnnouncementController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILoggerService _logger;
        private readonly IMapper _mapper;

        public AnnouncementController(IUnitOfWork unitOfWork, ILoggerService logger,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
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

        [HttpGet("{id}", Name = "AnnouncementById")]
        public async Task<ActionResult<Announcement>> GetById(int id)
        {
            var announcement = await _unitOfWork.Announcement.GetByIdAsync(id);
            if (announcement == null)
            {
                _logger.LogInfo($"Announcement with id: {id} doesn't exist in the database.");
                return NotFound();
            }
            else
            {
                return Ok(announcement);
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