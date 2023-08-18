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
    public class TopbarDal : BaseRepository<Topbar, ProjeContext>, ITopbarDal
    {
        public IList<TopbarListDto> GetTopbarListDal()
        {
            using (var context = new ProjeContext())
            {
                var a = context.Topbars.Select(topbar => new TopbarListDto()
                {
                    Id = topbar.Id,
                Title= topbar.Title,
                Address= topbar.Address,
                Mail= topbar.Mail,
                SocialMedya1 = topbar.SocialMedya1,
                SocialMedya2 = topbar.SocialMedya2,
                SocialMedya3 = topbar.SocialMedya3,
                SocialMedya4 = topbar.SocialMedya4,

                    LastUpdateedAt = topbar.LastUpdatedAt,
                    CreatedFullName = topbar.User.Name,//bunu about user ilişkisinden userdan çektik
                    IsActive = topbar.IsActive,
                    RowOrder = topbar.RowOrder
                });
                return a.ToList();
            }
        }
    }
}
