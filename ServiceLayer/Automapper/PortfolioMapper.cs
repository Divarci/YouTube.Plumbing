using AutoMapper;
using EntityLayer.WebApplication.Entities;
using EntityLayer.WebApplication.ViewModels.HomePage;

namespace ServiceLayer.Automapper
{
    public class PortfolioMapper : Profile
    {
        public PortfolioMapper()
        {
            CreateMap<Portfolio, HomePageListVM>().ReverseMap();
            CreateMap<Portfolio, HomePageAddVM>().ReverseMap();
            CreateMap<Portfolio, HomePageUpdateVM>().ReverseMap();
        }
    }
}
