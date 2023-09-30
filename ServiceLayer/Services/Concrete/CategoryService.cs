using AutoMapper;
using AutoMapper.QueryableExtensions;
using EntityLayer.WebApplication.Entities;
using EntityLayer.WebApplication.ViewModels.Category;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repositories.Abstract;
using RepositoryLayer.UnitOfWorks.Abstract;
using ServiceLayer.Services.Abstract;

namespace ServiceLayer.Services.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IGenericRepositories<Category> _repository;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _repository = _unitOfWork.GetGenericRepository<Category>();
        }




        public async Task<List<CategoryListVM>> GetAllListAsync()
        {
            var categoryListVM = await _repository.GetAlltEntityList().ProjectTo<CategoryListVM>(_mapper.ConfigurationProvider).ToListAsync();

            return categoryListVM;
        }

        public async Task AddCategoryAsync(CategoryAddVM request)
        {
            var category = _mapper.Map<Category>(request);
            await _repository.AddEntityAsync(category);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteCategoryAsync(int id)
        {
            var category = await _repository.GetEntityByIdAsync(id);
            _repository.DeletetEntity(category);
            await _unitOfWork.CommitAsync();
        }

        public async Task<CategoryUpdateVM> GetCategoryById(int id)
        {
            var category = await _repository.Where(x => x.Id == id).ProjectTo<CategoryUpdateVM>(_mapper.ConfigurationProvider).SingleAsync();
            return category;
        }

        public async Task UpdateCategoryAsync(CategoryUpdateVM request)
        {
            var category = _mapper.Map<Category>(request);
            _repository.UpdatetEntity(category);
            await _unitOfWork.CommitAsync();
        }
    }
}
