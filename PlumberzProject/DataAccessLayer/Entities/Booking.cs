using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Booking:BaseEntity
    {
        [DisplayName("Adı ve Soyadı")]
        public string FullName { get; set; }

        [DisplayName("E-Posta Adresiniz")]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }

        [DisplayName("Rezervasyon Tarihi")]
        [DataType(DataType.DateTime)]
        public DateTime Tarih { get; set; }

        [DisplayName("Açıklama")]
        public string Description { get; set; }

    }
}
