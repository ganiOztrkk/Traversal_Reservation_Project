using AutoMapper;
using DTOLayer.DTOs.AnnouncementDTOs;
using DTOLayer.DTOs.AppUserDTOs;
using EntityLayer.Concrete;

namespace TraversalProject.Mapping.AutoMapperProfile;

public class MapProfile : Profile
{
    public MapProfile()
    {
        CreateMap<AnnouncementAddDTOs, Announcement>().ReverseMap();
        CreateMap<AppUserRegisterDTOs, AppUser>().ReverseMap();
        CreateMap<AppUserLoginDTOs, AppUser>().ReverseMap();
    }
}