using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Dtos.AdminDtos
{
  public class FactListDto:AdminBaseDto
    {

        [DisplayName("Toplam Tecrübe")]
        public int YearsExperince { get; set; }
        [DisplayName("Uzamn Teknisyem")]
        public int ExpertTechnicon { get; set; }
        [DisplayName("Memnun Müşteri")]
        public int PleasedCustomerr { get; set; }
        [DisplayName("Tamamlanan İş")]
        public int CompletedProject { get; set; }
    }
}
