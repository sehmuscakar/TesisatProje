using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Entities;
using DataAccessLayer.Entities.Dtos;
using DataAccessLayer.Entities.Dtos.AdminDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutManager
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void Add(About about)
        {
           about.CreatedBy = 1;
           about.IsActive = true;
            var roworder = _aboutDal.GetActiveList().Count();
            about.RowOrder = roworder + 1;
            _aboutDal.Add(about);
        }

        public IList<AboutListDto> GetAboutListManager()
        {
            var listele = _aboutDal.GetAboutListDal();
            return listele;
        }

        public About GetById(int id)
        {
            Expression<Func<About, bool>> filter = x => x.Id == id;
            return _aboutDal.Get(filter);
        }

        public IList<About> GetList()
        {
            var listele = _aboutDal.GetActiveList();
            return listele;
        }

        public IList<NavbarListDto> GetNavbarListManager()
        {
            var data = _aboutDal.GetNavbarListDal();
            return data;
        }

        public void Remove(About about)
        {
            _aboutDal.Delete(about);
        }

        public void Update(About about)
        {
            about.CreatedBy = 1;
            about.IsActive = true;
            var roworder = _aboutDal.GetActiveList().Count();
           about.RowOrder = roworder;
           about.LastUpdatedAt = DateTime.Now;
            _aboutDal.Update(about);
        }
    }
}
