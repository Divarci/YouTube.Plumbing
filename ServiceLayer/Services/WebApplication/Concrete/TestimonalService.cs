using AutoMapper;
using AutoMapper.QueryableExtensions;
using CoreLayer.Enumerators;
using EntityLayer.WebApplication.Entities;
using EntityLayer.WebApplication.ViewModels.Testimonal;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using RepositoryLayer.Repositories.Abstract;
using RepositoryLayer.UnitOfWorks.Abstract;
using ServiceLayer.Helpers.Generic.Image;
using ServiceLayer.Messages.WebApplication;
using ServiceLayer.Services.WebApplication.Abstract;

namespace ServiceLayer.Services.WebApplication.Concrete
{
    public class TestimonalService : ITestimonalService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IGenericRepositories<Testimonal> _repository;
        private readonly IImageHelper _imageHelper;
        private readonly IToastNotification _toasty;
        private const string Section = "Testimonal";

        public TestimonalService(IUnitOfWork unitOfWork, IMapper mapper, IImageHelper imageHelper, IToastNotification toasty)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _repository = _unitOfWork.GetGenericRepository<Testimonal>();
            _imageHelper = imageHelper;
            _toasty = toasty;
        }



        public async Task<List<TestimonalListVM>> GetAllListAsync()
        {
            var testimonalListVM = await _repository.GetAlltEntityList().ProjectTo<TestimonalListVM>(_mapper.ConfigurationProvider).ToListAsync();

            return testimonalListVM;
        }

        public async Task AddTestimonalAsync(TestimonalAddVM request)
        {
            var imageResult = await _imageHelper.ImageUpload(request.Photo, ImageType.testimonal, null);
            if (imageResult.Error != null)
            {
                _toasty.AddErrorToastMessage(imageResult.Error, new ToastrOptions { Title = NotificationMessagesWebApplication.FailedTitle });
                return;
            }
            request.FileName = imageResult.Filename!;
            request.FileType = imageResult.FileType!;

            var testimonal = _mapper.Map<Testimonal>(request);
            await _repository.AddEntityAsync(testimonal);
            await _unitOfWork.CommitAsync();

            _toasty.AddSuccessToastMessage(NotificationMessagesWebApplication.AddMessage(Section), new ToastrOptions { Title = NotificationMessagesWebApplication.SuccessedTitle });
        }

        public async Task DeleteTestimonalAsync(int id)
        {
            var testimonal = await _repository.GetEntityByIdAsync(id);
            _repository.DeletetEntity(testimonal);
            await _unitOfWork.CommitAsync();

            _imageHelper.DeleteImage(testimonal.FileName);

            _toasty.AddWarningToastMessage(NotificationMessagesWebApplication.DeleteMessage(Section), new ToastrOptions { Title = NotificationMessagesWebApplication.SuccessedTitle });
        }

        public async Task<TestimonalUpdateVM> GetTestimonalById(int id)
        {
            var testimonal = await _repository.Where(x => x.Id == id).ProjectTo<TestimonalUpdateVM>(_mapper.ConfigurationProvider).SingleAsync();
            return testimonal;
        }

        public async Task UpdateTestimonalAsync(TestimonalUpdateVM request)
        {
            var oldTestimonal = await _repository.Where(x => x.Id == request.Id).AsNoTracking().FirstAsync();

            if (request.Photo != null)
            {
                var imageResult = await _imageHelper.ImageUpload(request.Photo, ImageType.testimonal, null);
                if (imageResult.Error != null)
                {
                    _toasty.AddErrorToastMessage(imageResult.Error, new ToastrOptions { Title = NotificationMessagesWebApplication.FailedTitle });
                    return;
                }
                request.FileName = imageResult.Filename!;
                request.FileType = imageResult.FileType!;
            }

            var testimonal = _mapper.Map<Testimonal>(request);
            _repository.UpdatetEntity(testimonal);
            await _unitOfWork.CommitAsync();

            if (request.Photo != null)
            {
                _imageHelper.DeleteImage(oldTestimonal.FileName);
            }

            _toasty.AddInfoToastMessage(NotificationMessagesWebApplication.UpdateMessage(Section), new ToastrOptions { Title = NotificationMessagesWebApplication.SuccessedTitle });
        }
    }
}
