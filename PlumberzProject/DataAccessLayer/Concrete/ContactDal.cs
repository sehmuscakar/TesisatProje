using CoreLayer.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.Entities;
using DataAccessLayer.Entities.Dtos.AdminDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class ContactDal : BaseRepository<Contact, ProjeContext>, IContactDal
    {
        public IList<ContactListDto> GetContactListDal()
        {
            using (var context = new ProjeContext())
            {
                var a = context.Contacts.Select(contact => new ContactListDto()
                {
                    Id = contact.Id,
                Name= contact.Name,
                Mail= contact.Mail,
                Subject= contact.Subject,
                Message= contact.Message,   
                    LastUpdateedAt = contact.LastUpdatedAt,
                    IsActive = contact.IsActive,
                    RowOrder = contact.RowOrder,
                    CreatedFullName = contact.User.Name,//ıd yerine name atadık
                });
                return a.ToList();
            }
        }
    }
}
