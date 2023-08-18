using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{        //slayder için bu kısım
  public class Carousel:BaseEntity
    {
        [DisplayName("Şube")]
        public string CityBranch { get; set; }
        [DisplayName("Şehir")]
        public string City { get; set; }
        [DisplayName("Açıklama")]
        public string CityDescription { get; set; }
        [DisplayName("Resim")]

        public string Image { get; set; }
    }
}
