using CoreLayer.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.Entities;
using DataAccessLayer.Entities.Dtos.AdminDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class FactDal : BaseRepository<Fact, ProjeContext>, IFactDal
    {
        public IList<FactListDto> GetFactListDal()
        {
            using (var context = new ProjeContext())
            {
                var a = context.Facts.Select(fact => new FactListDto()
                {
                    Id = fact.Id,
                    YearsExperince = fact.YearsExperince,
                    ExpertTechnicon = fact.ExpertTechnicon,
                    PleasedCustomerr = fact.PleasedCustomerr,
                    CompletedProject = fact.CompletedProject,
                    LastUpdateedAt = fact.LastUpdatedAt,
                    IsActive = fact.IsActive,
                    RowOrder = fact.RowOrder,
                    CreatedFullName = fact.User.Name,//ıd yerine name atadık
                });
                return a.ToList();
            }
        }
    }
}
