using AutoMapper;
using AutoMapper.QueryableExtensions;
using EntityLayer.WebApplication.Entities;
using EntityLayer.WebApplication.ViewModels.Contact;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repositories.Abstract;
using RepositoryLayer.UnitOfWorks.Abstract;
using ServiceLayer.Services.Abstract;

namespace ServiceLayer.Services.Concrete
{
    public class ContactService :IContactService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IGenericRepositories<Contact> _repository;

        public ContactService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _repository = _unitOfWork.GetGenericRepository<Contact>();
        }




        public async Task<List<ContactListVM>> GetAllListAsync()
        {
            var contactListVM = await _repository.GetAlltEntityList().ProjectTo<ContactListVM>(_mapper.ConfigurationProvider).ToListAsync();

            return contactListVM;
        }

        public async Task AddContactAsync(ContactAddVM request)
        {
            var contact = _mapper.Map<Contact>(request);
            await _repository.AddEntityAsync(contact);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteContactAsync(int id)
        {
            var contact = await _repository.GetEntityByIdAsync(id);
            _repository.DeletetEntity(contact);
            await _unitOfWork.CommitAsync();
        }

        public async Task<ContactUpdateVM> GetContactById(int id)
        {
            var contact = await _repository.Where(x => x.Id == id).ProjectTo<ContactUpdateVM>(_mapper.ConfigurationProvider).SingleAsync();
            return contact;
        }

        public async Task UpdateContactAsync(ContactUpdateVM request)
        {
            var contact = _mapper.Map<Contact>(request);
            _repository.UpdatetEntity(contact);
            await _unitOfWork.CommitAsync();
        }
    }
}
