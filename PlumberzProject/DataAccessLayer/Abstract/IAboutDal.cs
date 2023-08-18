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
   public interface IAboutDal:IEntityRepository<About>
    {

        IList<NavbarListDto> GetNavbarListDal();  //normal admin dışinda 

        IList<AboutListDto> GetAboutListDal();
    }
}
