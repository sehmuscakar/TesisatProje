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
    public class TeamDal : BaseRepository<Team, ProjeContext>, ITeamDal
    {
        public IList<TeamListDto> GetTeamListDal()
        {

            using (var context = new ProjeContext())
            {
                var a = context.Teams.Select(team => new TeamListDto()
                {
                    Id = team.Id,
             Image=team.Image,
             FullName=team.FullName,
             Duty=team.Duty,
             SocialMedya1=team.SocialMedya1,
             SocialMedya2=team.SocialMedya2,
             SocialMedya3=team.SocialMedya3,
                   LastUpdateedAt = team.LastUpdatedAt,
                    CreatedFullName = team.User.Name,//bunu about user ilişkisinden userdan çektik
                    IsActive = team.IsActive,
                    RowOrder = team.RowOrder
                });
                return a.ToList();
            }
        }
    }
}
