using AutoMapper;
using AutoMapper.QueryableExtensions;
using EntityLayer.WebApplication.Entities;
using EntityLayer.WebApplication.ViewModels.Service;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using RepositoryLayer.Repositories.Abstract;
using RepositoryLayer.UnitOfWorks.Abstract;
using ServiceLayer.Exception.WebApplication;
using ServiceLayer.Messages.WebApplication;
using ServiceLayer.Services.WebApplication.Abstract;

namespace ServiceLayer.Services.WebApplication.Concrete
{
    public class ServiceService : IServiceService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IGenericRepositories<Service> _repository;
        private readonly IToastNotification _toasty;
        private const string Section = "Service";

        public ServiceService(IUnitOfWork unitOfWork, IMapper mapper, IToastNotification toasty)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _repository = _unitOfWork.GetGenericRepository<Service>();
            _toasty = toasty;
        }



        public async Task<List<ServiceListVM>> GetAllListAsync()
        {
            var serviceListVM = await _repository.GetAlltEntityList().ProjectTo<ServiceListVM>(_mapper.ConfigurationProvider).ToListAsync();

            return serviceListVM;
        }

        public async Task AddServiceAsync(ServiceAddVM request)
        {
            var service = _mapper.Map<Service>(request);
            await _repository.AddEntityAsync(service);
            await _unitOfWork.CommitAsync();
            _toasty.AddSuccessToastMessage(NotificationMessagesWebApplication.AddMessage(Section), new ToastrOptions { Title = NotificationMessagesWebApplication.SuccessedTitle });
        }

        public async Task DeleteServiceAsync(int id)
        {
            var service = await _repository.GetEntityByIdAsync(id);
            _repository.DeletetEntity(service);
            await _unitOfWork.CommitAsync();
            _toasty.AddWarningToastMessage(NotificationMessagesWebApplication.DeleteMessage(Section), new ToastrOptions { Title = NotificationMessagesWebApplication.SuccessedTitle });
        }

        public async Task<ServiceUpdateVM> GetServiceById(int id)
        {
            var service = await _repository.Where(x => x.Id == id).ProjectTo<ServiceUpdateVM>(_mapper.ConfigurationProvider).SingleAsync();
            return service;
        }

        public async Task UpdateServiceAsync(ServiceUpdateVM request)
        {
            var service = _mapper.Map<Service>(request);
            _repository.UpdatetEntity(service);
            var result = await _unitOfWork.CommitAsync();

            if (!result)
            {
                throw new ClientSideExceptions(ExceptionMessages.ConcurencyException);
            }
            _toasty.AddInfoToastMessage(NotificationMessagesWebApplication.UpdateMessage(Section), new ToastrOptions { Title = NotificationMessagesWebApplication.SuccessedTitle });
        }


        //UI SIDE METHODS

        public async Task<List<ServiceListForUI>> GetAllListForUIAsync()
        {
            var serviceListForUI = await _repository.GetAlltEntityList().ProjectTo<ServiceListForUI>(_mapper.ConfigurationProvider).ToListAsync();

            return serviceListForUI;
        }

    }
}
