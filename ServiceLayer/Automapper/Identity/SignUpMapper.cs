using AutoMapper;
using EntityLayer.Identity.Entities;
using EntityLayer.Identity.ViewModels;

namespace ServiceLayer.Automapper.Identity
{
    public class SignUpMapper : Profile
    {
        public SignUpMapper()
        {
            CreateMap<AppUser,SignUpVM>().ReverseMap();
        }
    }
}
