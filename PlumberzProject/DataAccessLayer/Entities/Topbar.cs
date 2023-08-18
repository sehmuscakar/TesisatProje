
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Topbar:BaseEntity // Topbar alanı için , üst menü 
    {
        [DisplayName("Sol Başlık")]
        [Column(TypeName = "Varchar(20)")]
    
        public string  Title { get; set; }
       
        public string Address { get; set; }
        [DisplayName("Şirket Maili")]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }
        [DisplayName("Medya Adresi 1")]
        public string SocialMedya1 { get; set; }
        [DisplayName("Medya Adresi 2")]
        public string SocialMedya2 { get; set; }
        [DisplayName("Medya Adresi 3")]
        public string SocialMedya3 { get; set; }
        [DisplayName("Medya Adresi 4")]
        public string SocialMedya4 { get; set; }


        //[DisplayName("Acil Mesajı")]
        //public string Urgent { get; set; }
        //[DisplayName("Şirket Telefonu")]
        //[DataType(DataType.PhoneNumber)]
        //public string Phone { get; set; }

    




    }
}
