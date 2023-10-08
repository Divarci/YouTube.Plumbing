using AutoMapper;
using EntityLayer.Identity.Entities;
using EntityLayer.Identity.ViewModels;

namespace ServiceLayer.Automapper.Identity
{
    public class ForgotPasswordMapper : Profile
    {
        public ForgotPasswordMapper()
        {
            CreateMap<AppUser,ForgotPasswordVM>().ReverseMap();
        }
    }
}
