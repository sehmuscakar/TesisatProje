using CoreLayer.DataAccess;
using DataAccessLayer.Entities;
using DataAccessLayer.Entities.Dtos;
using DataAccessLayer.Entities.Dtos.AdminDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IFactDal:IEntityRepository<Fact>
    {
        IList<FactListDto> GetFactListDal();
     
    }
}
