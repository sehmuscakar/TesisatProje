using CoreLayer.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.Entities;
using DataAccessLayer.Entities.Dtos.AdminDtos;

namespace DataAccessLayer.Concrete
{
    public class ServiceDal : BaseRepository<Service, ProjeContext>, IServiceDal
    {
        //public IList<ServiceListDto2> GetServiceList2Dal()
        //{
        //    using (var context = new ProjeContext())
        //    {
        //        var a = context.Services.Select(service2 => new ServiceListDto2()
        //        {
        //            Id= service2.Id,

        //            Header= service2.Header,
        //            Description= service2.Description,
        //            ServiceTitle1 = service2.ServiceTitle1,
        //            ServiceTitle2= service2.ServiceTitle2,
        //            ServiceTitle3= service2.ServiceTitle3,
        //            İcon= service2.İcon,
                    
                   

        //        });
        //        return a.ToList();
        //    }
        //}

        public IList<ServiceListDto> GetServiceListDal()
        {
            using (var context = new ProjeContext())
            {
                var a = context.Services.Select(service => new ServiceListDto()
                {
                    Id = service.Id,
              
                Header= service.Header, 
                Description= service.Description,
                ServiceTitle1= service.ServiceTitle1,
                ServiceTitle2= service.ServiceTitle2,
                ServiceTitle3= service.ServiceTitle3,
                İcon= service.İcon,
                    CreatedFullName = service.User.Name,//bunu about user ilişkisinden userdan çektik
                    LastUpdateedAt=service.LastUpdatedAt,
                    IsActive = service.IsActive,
                    RowOrder = service.RowOrder
                });
                return a.ToList();
            }
        }
    }
}
