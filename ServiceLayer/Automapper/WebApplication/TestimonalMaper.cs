using AutoMapper;
using EntityLayer.WebApplication.Entities;
using EntityLayer.WebApplication.ViewModels.Testimonal;

namespace ServiceLayer.Automapper.WebApplication
{
    public class TestimonalMaper : Profile
    {
        public TestimonalMaper()
        {
            CreateMap<Testimonal, TestimonalListVM>().ReverseMap();
            CreateMap<Testimonal, TestimonalAddVM>().ReverseMap();
            CreateMap<Testimonal, TestimonalUpdateVM>().ReverseMap();
        }
    }
}
