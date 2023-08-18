using DataAccessLayer.Entities;
using DataAccessLayer.Entities.Dtos.AdminDtos;

namespace BusinessLayer.Abstract
{
    public interface IContactManager
    {
        IList<ContactListDto> GetContactListManager();
        IList<Contact> GetList();
        void Add(Contact contact);

        void Update(Contact contact);

        void Remove(Contact contact);

       Contact GetById(int id);

    }
}
