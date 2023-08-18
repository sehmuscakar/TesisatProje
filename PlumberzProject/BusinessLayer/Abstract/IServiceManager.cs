using DataAccessLayer.Entities;
using DataAccessLayer.Entities.Dtos.AdminDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IServiceManager
    {
        IList<ServiceListDto> GetServiceListManager();
        IList<Service> GetList();
        void Add(Service service);

        void Update(Service service);

        void Remove(Service service);

        Service GetById(int id);

    }
}
