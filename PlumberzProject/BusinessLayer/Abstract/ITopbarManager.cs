using DataAccessLayer.Entities;
using DataAccessLayer.Entities.Dtos.AdminDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface ITopbarManager
    {
        IList<TopbarListDto> GetTopbarListManager();
        IList<Topbar> GetList();
        void Add(Topbar topbar);

        void Update(Topbar topbar);

        void Remove(Topbar topbar);

       Topbar  GetById(int id);

    }
}
