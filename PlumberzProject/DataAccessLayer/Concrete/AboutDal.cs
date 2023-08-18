using CoreLayer.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.Entities;
using DataAccessLayer.Entities.Dtos;
using DataAccessLayer.Entities.Dtos.AdminDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class AboutDal : BaseRepository<About, ProjeContext>, IAboutDal
    {
        public IList<AboutListDto> GetAboutListDal()
        {
            using (var context = new ProjeContext())
            {
                var a = context.Abouts.Select(about => new AboutListDto()
                {
                  Id = about.Id,
                 Header=about.Header,
                 Description=about.Description,
                 ServiceTitle1= about.ServiceTitle1,
                 ServiceTitle2= about.ServiceTitle2,
                 ServiceTitle3= about.ServiceTitle3,
                 İmage1=about.İmage1,
                 İmage2=about.İmage2,
                 Urgent=about.Urgent,
                 Phone=about.Phone,
                 LastUpdateedAt=about.LastUpdatedAt,
                 CreatedFullName=about.User.Name,//bunu about user ilişkisinden userdan çektik
                 IsActive=about.IsActive,
                 RowOrder=about.RowOrder
                });
                return a.ToList();
            }
        }

        public IList<NavbarListDto> GetNavbarListDal()//burda aboutdaki urggent ve phoneyi nabarlistdto yu taşıdık ki urgent ile phoneyi verilerini nabvarlistdto üzerinden çekebilelim
        {
            using (var context = new ProjeContext())
            {
                var a = context.Abouts.Select(about => new NavbarListDto() 
                {
                  ID=about.Id,
                   Urgent=about.Urgent,
                   Phone=about.Phone,
                 
                });
                return a.ToList();
            }
        }
    }
}
