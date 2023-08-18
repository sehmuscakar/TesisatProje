using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Dtos.AdminDtos
{
    public class CarouselListDto:AdminBaseDto
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
