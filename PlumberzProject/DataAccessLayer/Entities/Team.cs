using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DataAccessLayer.Entities
{
    public class Team:BaseEntity
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
