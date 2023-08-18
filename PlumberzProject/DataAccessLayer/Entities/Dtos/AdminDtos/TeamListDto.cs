using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Dtos.AdminDtos
{
  public class TeamListDto:AdminBaseDto
    {
        [DisplayName("Resim")]

        public string Image { get; set; }
        [DisplayName("Adı ve Soyadı")]
        public string FullName { get; set; }
        [DisplayName("Görevi")]
        public string Duty { get; set; }
        [DisplayName("Sosyal Medya1")]
        public string SocialMedya1 { get; set; }
        [DisplayName("Sosyal Medya2")]
        public string SocialMedya2 { get; set; }
        [DisplayName("Sosyal Medya3")]
        public string SocialMedya3 { get; set; }
    }
}
