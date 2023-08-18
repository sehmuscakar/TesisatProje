using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IRegisterManager
    {
        IList<User> GetList();
        void Add(User user);

        void Update(User user);

        void Remove(User user);

        User GetById(int id);

    }
}
