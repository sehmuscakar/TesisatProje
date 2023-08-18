using CoreLayer.Entities.Abstract;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Entities
{
    public class BaseEntity:IEntity
    {
        public int Id { get; set; }
        [DisplayName("Pasif/Aktif")]
  
        public bool IsActive { get; set; }
        [DisplayName("Son Güncellenme Tarihi")]
        [DataType(DataType.DateTime)]
        public DateTime? LastUpdatedAt { get; set; }
    
        [DisplayName("Sırası")]
        public int RowOrder { get; set; }
        [DisplayName("Kim Oluşturdu")]
        public int? CreatedBy { get; set; }
        public virtual User User { get; set; }  // tekli olanın forein keyi olur oda burda işte Createdby userın forenkeyi dir


    }
}
