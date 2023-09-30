using AutoMapper;
using EntityLayer.WebApplication.Entities;
using EntityLayer.WebApplication.ViewModels.HomePage;
using EntityLayer.WebApplication.ViewModels.Service;

namespace ServiceLayer.Automapper
{
    public class ServiceMapper : Profile
    {
        public ServiceMapper()
        {
            CreateMap<Service, ServiceListVM>().ReverseMap();
            CreateMap<Service, ServiceAddVM>().ReverseMap();
            CreateMap<Service, ServiceUpdateVM>().ReverseMap();
        }
    }
}
