using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Entities;
using DataAccessLayer.Entities.Dtos.AdminDtos;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class TeamManager : ITeamManager
    {
        private readonly ITeamDal _teamDal;

        public TeamManager(ITeamDal teamDal)
        {
            _teamDal = teamDal;
        }

        public void Add(Team team)
        {
            team.CreatedBy = 1;
            team.IsActive = true;
            var roworder = _teamDal.GetActiveList().Count();
            team.RowOrder = roworder + 1;
            _teamDal.Add(team); 
        }

        public Team GetById(int id)
        {
            Expression<Func<Team, bool>> filter = x => x.Id == id;
            return _teamDal.Get(filter);
        }

        public IList<Team> GetList()
        {
            var list = _teamDal.GetActiveList();
            return list;
        }

        public IList<TeamListDto> GetTeamListManager()
        {
            var listele = _teamDal.GetTeamListDal();
            return listele;
        }

        public void Remove(Team team)
        {
            _teamDal.Delete(team);
        }

        public void Update(Team team)
        {
            team.CreatedBy = 1;
           team.IsActive = true;
            var roworder = _teamDal.GetActiveList().Count();
           team.RowOrder = roworder;
           team.LastUpdatedAt = DateTime.Now;
            _teamDal.Update(team);
        }
    }
}
