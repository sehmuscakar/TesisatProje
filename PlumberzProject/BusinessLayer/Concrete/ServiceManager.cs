using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Entities;
using DataAccessLayer.Entities.Dtos.AdminDtos;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class ServiceManager : IServiceManager
    {

        private readonly IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            this._serviceDal = serviceDal;
        }

        public void Add(Service service)
        {
            service.CreatedBy = 1;
            service.IsActive = true;
            var roworder = _serviceDal.GetActiveList().Count();
           service.RowOrder = roworder + 1;
            _serviceDal.Add(service);
        }

        public Service GetById(int id)
        {
            Expression<Func<Service, bool>> filter = x => x.Id == id;
            return _serviceDal.Get(filter);
        }

        public IList<Service> GetList()
        {
            var list = _serviceDal.GetActiveList();
            return list;    
        }

        public IList<ServiceListDto> GetServiceListManager()
        {
            var list = _serviceDal.GetServiceListDal();
            return list;
        }

        public void Remove(Service service)
        {
            _serviceDal.Delete(service);
        }

        public void Update(Service service)
        {
            service.CreatedBy = 1;
            service.IsActive = true;
            var roworder = _serviceDal.GetActiveList().Count();
           service.RowOrder = roworder;
           service.LastUpdatedAt = DateTime.Now;
            _serviceDal.Update(service);
        }
    }
}
