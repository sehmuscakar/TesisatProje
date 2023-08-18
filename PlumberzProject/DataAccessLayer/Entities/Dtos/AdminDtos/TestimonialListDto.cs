using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Dtos.AdminDtos
{
    public class TestimonialListDto:AdminBaseDto
    {
        [DisplayName("Açıklama")]
        public string Decsription { get; set; }
        [DisplayName("Adı ve Soyadı")]
        public string FullNnme { get; set; }
        [DisplayName("Yapılan iş")]
        public string Profession { get; set; }//yapılan iş

        [DisplayName("Resim")]
        public string Image { get; set; }
        [DisplayName("Yıldız Sayısı")]
        public int star { get; set; }

    }
}
