using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
   public class Contact:BaseEntity
    {
        [DisplayName("Adınız")]
        public string Name { get; set; }
        [DisplayName("Mailiniz")]
        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }
        [DisplayName("Mesaj Başlığı")]
        public string Subject { get; set; }
        [DisplayName("Mesaj")]
        public string Message { get; set; }

    }
}
