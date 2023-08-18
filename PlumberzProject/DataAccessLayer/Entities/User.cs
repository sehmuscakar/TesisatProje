using CoreLayer.Entities.Abstract;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities
{
    public class User:IEntity // user kendisi tekli olacak
    {
        public int Id { get; set; }

        [DisplayName("Adınız")]
        public string Name { get; set; }
        [DisplayName("E-Posta")]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }
        [DisplayName("Kullanıcı Adı")]
        public string UserName { get; set; }
        [DisplayName("Şİfre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Şartlar ve Koşuları kabul etme")]
        public bool IsActive { get; set; }
        [DisplayName("Eklenme Sırası")]
        public int RowOrder { get; set; }

        public virtual ICollection<About> Abouts { get; set; }   //bunlar çokludur.
        public virtual ICollection<Booking> Bookings { get; set; }  
        public virtual ICollection<Carousel> Carousels { get; set; }  
        public virtual ICollection<Fact> Facts { get; set; }  
        public virtual ICollection<Service> services { get; set; }  
        public virtual ICollection<Team> Teams { get; set; }  
        public virtual ICollection<Testimonial> Testimonials { get; set; }  
        public virtual ICollection<Topbar> Topbars { get; set; }  
        public virtual ICollection<Contact> Contacts { get; set; }  

    }
}
