using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities.Dtos.AdminDtos
{
    public class AdminBaseDto
    {
        public int Id { get; set; }

        public DateTime? LastUpdateedAt { get; set; }
        public string CreatedFullName { get; set; }

        public bool IsActive { get; set; }

        public int RowOrder { get; set; }
    }
}
