using CoreLayer.DataAccess;
using DataAccessLayer.Entities;
using DataAccessLayer.Entities.Dtos.AdminDtos;

namespace DataAccessLayer.Abstract
{
    public interface IServiceDal:IEntityRepository<Service>
    {

        IList<ServiceListDto> GetServiceListDal();

        //IList<ServiceListDto2> GetServiceList2Dal();// bunu ıu katmanı için yapıyoruz admin için değil 
    }
}
