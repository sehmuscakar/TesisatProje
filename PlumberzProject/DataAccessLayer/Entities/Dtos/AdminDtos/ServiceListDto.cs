using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Dtos.AdminDtos
{
   public  class ServiceListDto:AdminBaseDto
    {
        [DisplayName("Ana Başlık")]
        public string Header { get; set; }
        [DisplayName("Açıklama")]

        public string Description { get; set; }
        [DisplayName("Hizmet Başlığı 1")]

        public string ServiceTitle1 { get; set; }
        [DisplayName("Hizmet Başlığı 2")]

        public string ServiceTitle2 { get; set; }
        [DisplayName("Hizmet Başlığı 3")]

        public string ServiceTitle3 { get; set; }
        [DisplayName("İcon")]

        public string İcon { get; set; }

      
    }
}
