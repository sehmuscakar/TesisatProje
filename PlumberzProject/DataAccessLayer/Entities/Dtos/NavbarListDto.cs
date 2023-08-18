using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Dtos
{
    public class NavbarListDto
    {

        public int ID { get; set; }
        public IList<About> about { get; set; } //about entitylerini getirdik list şeklinde listeleme yapacaz çünkü

        [DisplayName("Acil Mesajı")]

        public string Urgent { get; set; }

        [DataType(DataType.PhoneNumber)]
        [DisplayName("Şirket Telefon")]
        public string Phone { get; set; }
    }
}
