using DataAccessLayer.Entities;
using DataAccessLayer.Entities.Dtos.AdminDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IFactManager
    {
        IList<FactListDto> GetFactListManager();
        IList<Fact> GetList();
        void Add(Fact fact);

        void Update(Fact fact);

        void Remove(Fact fact);

        Fact GetById(int id);

    }
}
