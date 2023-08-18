using System.ComponentModel;

namespace DataAccessLayer.Entities
{
    public class Service:BaseEntity
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

    //    public int? YearsExperince { get; set; } //boş geçilebilsin ki bunun verisini fact üzerinden dto ile çekecez sadece alan olması lazım olduğu için yazıyoruz bu propertyi

    }
}
