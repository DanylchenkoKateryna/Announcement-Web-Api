using AutoMapper;
using Data.DTO;
using Data.Entities;

namespace Data
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<CreateAnnouncementDTO,Announcement>()
                .ForMember(u => u.DateAdded,opt=>opt.MapFrom(x=>DateTime.Now))
                .ReverseMap();

            CreateMap<UpdateAnnouncementDTO, Announcement>()
               .ReverseMap();
        }
       
    }
}
