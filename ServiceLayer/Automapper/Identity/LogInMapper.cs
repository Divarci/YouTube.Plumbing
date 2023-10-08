using AutoMapper;
using EntityLayer.Identity.Entities;
using EntityLayer.Identity.ViewModels;

namespace ServiceLayer.Automapper.Identity
{
    public class LogInMapper : Profile
    {
        public LogInMapper()
        {
            CreateMap<AppUser, LogInVM>().ReverseMap();
        }
    }
}
