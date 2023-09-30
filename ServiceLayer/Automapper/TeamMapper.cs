using AutoMapper;
using EntityLayer.WebApplication.Entities;
using EntityLayer.WebApplication.ViewModels.Team;

namespace ServiceLayer.Automapper
{
    public class TeamMapper : Profile
    {
        public TeamMapper()
        {
            CreateMap<Team, TeamListVM>().ReverseMap();
            CreateMap<Team, TeamAddVM>().ReverseMap();
            CreateMap<Team, TeamUpdateVM>().ReverseMap();
        }
    }
}
