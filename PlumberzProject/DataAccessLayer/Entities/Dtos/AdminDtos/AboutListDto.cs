using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Dtos.AdminDtos
{
  public class AboutListDto:AdminBaseDto
    {
      
        public string Header { get; set; }   
        public string Description { get; set; }
        public string ServiceTitle1 { get; set; }
        public string ServiceTitle2 { get; set; }
        public string ServiceTitle3 { get; set; }

        public string İmage1 { get; set; }
   
        public string İmage2 { get; set; }
        public string Urgent { get; set; }
        public string Phone { get; set; }

       

    }
}
