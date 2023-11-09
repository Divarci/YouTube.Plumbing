using AutoMapper;
using EntityLayer.Identity.Entities;
using EntityLayer.Identity.ViewModels;

namespace ServiceLayer.Automapper.Identity
{
    public class UserEditMapper : Profile
    {
        public UserEditMapper()
        {
            CreateMap<AppUser,UserEditVM>().ReverseMap();
            CreateMap<AppUser,UserVM>().ReverseMap();
        }
    }
}
