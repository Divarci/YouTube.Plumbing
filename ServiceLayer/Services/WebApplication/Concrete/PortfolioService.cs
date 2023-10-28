using AutoMapper;
using AutoMapper.QueryableExtensions;
using CoreLayer.Enumerators;
using EntityLayer.WebApplication.Entities;
using EntityLayer.WebApplication.ViewModels.Portfolio;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using RepositoryLayer.Repositories.Abstract;
using RepositoryLayer.UnitOfWorks.Abstract;
using ServiceLayer.Helpers.Generic.Image;
using ServiceLayer.Messages.WebApplication;
using ServiceLayer.Services.WebApplication.Abstract;

namespace ServiceLayer.Services.WebApplication.Concrete
{
    public class PortfolioService : IPortfolioService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IGenericRepositories<Portfolio> _repository;
        private readonly IImageHelper _imageHelper;
        private readonly IToastNotification _toasty;
        private const string Section = "Portfolio";

        public PortfolioService(IUnitOfWork unitOfWork, IMapper mapper, IImageHelper imageHelper, IToastNotification toasty)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _repository = _unitOfWork.GetGenericRepository<Portfolio>();
            _imageHelper = imageHelper;
            _toasty = toasty;
        }



        public async Task<List<PortfolioListVM>> GetAllListAsync()
        {
            var portfolioListVM = await _repository.GetAlltEntityList().ProjectTo<PortfolioListVM>(_mapper.ConfigurationProvider).ToListAsync();

            return portfolioListVM;
        }

        public async Task AddPortfolioAsync(PortfolioAddVM request)
        {
            var imageResult = await _imageHelper.ImageUpload(request.Photo, ImageType.portfolio, null);
            if (imageResult.Error != null)
            {
                _toasty.AddErrorToastMessage(imageResult.Error, new ToastrOptions { Title = NotificationMessagesWebApplication.FailedTitle });
                return;
            }
            request.FileName = imageResult.Filename!;
            request.FileType = imageResult.FileType!;

            var portfolio = _mapper.Map<Portfolio>(request);
            await _repository.AddEntityAsync(portfolio);
            await _unitOfWork.CommitAsync();
            _toasty.AddSuccessToastMessage(NotificationMessagesWebApplication.AddMessage(Section), new ToastrOptions { Title = NotificationMessagesWebApplication.SuccessedTitle });
        }

        public async Task DeletePortfolioAsync(int id)
        {
            var portfolio = await _repository.GetEntityByIdAsync(id);
            _repository.DeletetEntity(portfolio);
            await _unitOfWork.CommitAsync();

            _imageHelper.DeleteImage(portfolio.FileName);
            _toasty.AddWarningToastMessage(NotificationMessagesWebApplication.DeleteMessage(Section), new ToastrOptions { Title = NotificationMessagesWebApplication.SuccessedTitle });

        }

        public async Task<PortfolioUpdateVM> GetPortfolioById(int id)
        {
            var portfolio = await _repository.Where(x => x.Id == id).ProjectTo<PortfolioUpdateVM>(_mapper.ConfigurationProvider).SingleAsync();
            return portfolio;
        }

        public async Task UpdatePortfolioAsync(PortfolioUpdateVM request)
        {
            var oldPortfolio = await _repository.Where(x => x.Id == request.Id).AsNoTracking().FirstAsync();

            if (request.Photo != null)
            {
                var imageResult = await _imageHelper.ImageUpload(request.Photo, ImageType.portfolio, null);
                if (imageResult.Error != null)
                {
                    _toasty.AddErrorToastMessage(imageResult.Error, new ToastrOptions { Title = NotificationMessagesWebApplication.FailedTitle });
                    return;
                }
                request.FileName = imageResult.Filename!;
                request.FileType = imageResult.FileType!;
            }

            var portfolio = _mapper.Map<Portfolio>(request);
            _repository.UpdatetEntity(portfolio);
            await _unitOfWork.CommitAsync();

            if (request.Photo != null)
            {
                _imageHelper.DeleteImage(oldPortfolio.FileName);
            }
            _toasty.AddInfoToastMessage(NotificationMessagesWebApplication.UpdateMessage(Section), new ToastrOptions { Title = NotificationMessagesWebApplication.SuccessedTitle });
        }
    }
}
