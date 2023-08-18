using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Entities;
using DataAccessLayer.Entities.Dtos.AdminDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactManager
    {

        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void Add(Contact contact)
        {
            contact.CreatedBy = 1;
            contact.IsActive = true;
            var roworder = _contactDal.GetActiveList().Count();
            contact.RowOrder = roworder + 1;
           _contactDal.Add(contact);
        }

        public Contact GetById(int id)
        {
            Expression<Func<Contact, bool>> filter = x => x.Id == id;
            return _contactDal.Get(filter);
        }

        public IList<ContactListDto> GetContactListManager()
        {
            var listdto = _contactDal.GetContactListDal();
            return listdto;
        }

        public IList<Contact> GetList()
        {
            var listele = _contactDal.GetActiveList();
            return listele;
        }

        public void Remove(Contact contact)
        {
            _contactDal.Delete(contact);    
        }

        public void Update(Contact contact)
        {
           contact.CreatedBy = 1;
           contact.IsActive = true;
            var roworder = _contactDal.GetActiveList().Count();
          contact.RowOrder = roworder;
          contact.LastUpdatedAt = DateTime.Now;
            _contactDal.Update(contact);
        }
    }
}
