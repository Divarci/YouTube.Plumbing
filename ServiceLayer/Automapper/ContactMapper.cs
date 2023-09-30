using AutoMapper;
using EntityLayer.WebApplication.Entities;
using EntityLayer.WebApplication.ViewModels.Category;
using EntityLayer.WebApplication.ViewModels.Contact;

namespace ServiceLayer.Automapper
{
    public class ContactMapper : Profile
    {
        public ContactMapper()
        {
            CreateMap<Contact, ContactListVM>().ReverseMap();
            CreateMap<Contact, ContactAddVM>().ReverseMap();
            CreateMap<Contact, ContactUpdateVM>().ReverseMap();
        }
    }
}
