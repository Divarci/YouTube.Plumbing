using AutoMapper;
using EntityLayer.WebApplication.Entities;
using EntityLayer.WebApplication.ViewModels.SocialMedia;

namespace ServiceLayer.Automapper
{
    public class SocialMediaMapper : Profile
    {
        public SocialMediaMapper()
        {
            CreateMap<SocialMedia, SocialMediaListVM>().ReverseMap();
            CreateMap<SocialMedia, SocialMediaAddVM>().ReverseMap();
            CreateMap<SocialMedia, SocialMediaUpdateVM>().ReverseMap();
        }
    }
}
