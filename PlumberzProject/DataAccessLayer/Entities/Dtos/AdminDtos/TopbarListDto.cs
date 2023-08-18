using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Dtos.AdminDtos
{
   public class TopbarListDto:AdminBaseDto
    {
        public string Title { get; set; }

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

    }
}
