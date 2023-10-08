using AutoMapper;
using EntityLayer.Identity.Entities;
using EntityLayer.Identity.ViewModels;

namespace ServiceLayer.Automapper.Identity
{
    public class ResetPasswordMapper : Profile
    {
        public ResetPasswordMapper()
        {
            CreateMap<AppUser,ResetPasswordVM>().ReverseMap();
        }
    }
}
