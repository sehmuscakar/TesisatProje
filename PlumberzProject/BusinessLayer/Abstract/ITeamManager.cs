using DataAccessLayer.Entities;
using DataAccessLayer.Entities.Dtos.AdminDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface ITeamManager
    {

        IList<TeamListDto> GetTeamListManager();
        IList<Team> GetList();
        void Add(Team team);

        void Update(Team team);

        void Remove(Team team);

        Team GetById(int id);

    }
}
