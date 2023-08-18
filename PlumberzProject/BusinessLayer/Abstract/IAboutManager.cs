using DataAccessLayer.Entities;
using DataAccessLayer.Entities.Dtos;
using DataAccessLayer.Entities.Dtos.AdminDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IAboutManager
    {

        IList<AboutListDto> GetAboutListManager();
        IList<NavbarListDto> GetNavbarListManager();
        IList<About> GetList();
        void Add(About about);

        void Update(About about);

        void Remove(About about);

        About GetById(int id);

    }
}
