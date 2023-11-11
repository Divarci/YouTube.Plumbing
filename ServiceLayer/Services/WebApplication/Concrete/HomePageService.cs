using AutoMapper;
using AutoMapper.QueryableExtensions;
using EntityLayer.WebApplication.Entities;
using EntityLayer.WebApplication.ViewModels.HomePage;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using RepositoryLayer.Repositories.Abstract;
using RepositoryLayer.UnitOfWorks.Abstract;
using ServiceLayer.Exception.WebApplication;
using ServiceLayer.Messages.WebApplication;
using ServiceLayer.Services.WebApplication.Abstract;

namespace ServiceLayer.Services.WebApplication.Concrete
{
    public class HomePageService : IHomePageService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IGenericRepositories<HomePage> _repository;
        private readonly IToastNotification _toasty;
        private const string Section = "Home Page section";

        public HomePageService(IUnitOfWork unitOfWork, IMapper mapper, IToastNotification toasty)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _repository = _unitOfWork.GetGenericRepository<HomePage>();
            _toasty = toasty;
        }



        public async Task<List<HomePageListVM>> GetAllListAsync()
        {
            var homePageListVM = await _repository.GetAlltEntityList().ProjectTo<HomePageListVM>(_mapper.ConfigurationProvider).ToListAsync();

            return homePageListVM;
        }

        public async Task AddHomePageAsync(HomePageAddVM request)
        {
            var homePage = _mapper.Map<HomePage>(request);
            await _repository.AddEntityAsync(homePage);
            await _unitOfWork.CommitAsync();
            _toasty.AddSuccessToastMessage(NotificationMessagesWebApplication.AddMessage(Section), new ToastrOptions { Title = NotificationMessagesWebApplication.SuccessedTitle });
        }

        public async Task DeleteHomePageAsync(int id)
        {
            var homePage = await _repository.GetEntityByIdAsync(id);
            _repository.DeletetEntity(homePage);
            await _unitOfWork.CommitAsync();
            _toasty.AddWarningToastMessage(NotificationMessagesWebApplication.DeleteMessage(Section), new ToastrOptions { Title = NotificationMessagesWebApplication.SuccessedTitle });
        }

        public async Task<HomePageUpdateVM> GetHomePageById(int id)
        {
            var homePage = await _repository.Where(x => x.Id == id).ProjectTo<HomePageUpdateVM>(_mapper.ConfigurationProvider).SingleAsync();
            return homePage;
        }

        public async Task UpdateHomePageAsync(HomePageUpdateVM request)
        {
            var homePage = _mapper.Map<HomePage>(request);
            _repository.UpdatetEntity(homePage);
            var result = await _unitOfWork.CommitAsync();

            if (!result)
            {
                throw new ClientSideExceptions(ExceptionMessages.ConcurencyException);
            }
            _toasty.AddInfoToastMessage(NotificationMessagesWebApplication.UpdateMessage(Section), new ToastrOptions { Title = NotificationMessagesWebApplication.SuccessedTitle });
        }




        //UI SERVICE METHODS

        public async Task<List<HomePageVMForUI>> GetAllListForUIAsync()
        {
            var homePageListVMForUi = await _repository.GetAlltEntityList().ProjectTo<HomePageVMForUI>(_mapper.ConfigurationProvider).ToListAsync();

            return homePageListVMForUi;
        }
    }
}
