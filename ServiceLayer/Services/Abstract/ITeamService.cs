using EntityLayer.WebApplication.ViewModels.SocialMedia;
using EntityLayer.WebApplication.ViewModels.Team;

namespace ServiceLayer.Services.Abstract
{
    public interface ITeamService
    {
        Task<List<TeamListVM>> GetAllListAsync();
        Task AddTeamAsync(TeamAddVM request);
        Task DeleteTeamAsync(int id);
        Task<TeamUpdateVM> GetTeamById(int id);
        Task UpdateTeamAsync(TeamUpdateVM request);
    }
}
