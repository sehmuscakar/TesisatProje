using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Entities;
using DataAccessLayer.Entities.Dtos.AdminDtos;
using System.Linq.Expressions;
using System.Security.Cryptography;

namespace BusinessLayer.Concrete
{
    public class TopbarManager : ITopbarManager
    {

        private readonly ITopbarDal _topbarDal;

        public TopbarManager(ITopbarDal topbarDal)
        {
            _topbarDal = topbarDal;
        }

        public void Add(Topbar topbar)
        {
            topbar.CreatedBy = 1;
           topbar.IsActive = true;
            var roworder = _topbarDal.GetActiveList().Count();
            topbar.RowOrder = roworder + 1;
            _topbarDal.Add(topbar);
        }

        public Topbar GetById(int id)
        {
            Expression<Func<Topbar, bool>> filter = x => x.Id == id;
            return _topbarDal.Get(filter);
        }

        public IList<Topbar> GetList()
        {
            var list = _topbarDal.GetActiveList();
            return list;
        }

        public IList<TopbarListDto> GetTopbarListManager()
        {
            var listdto = _topbarDal.GetTopbarListDal();
            return listdto; 
        }

        public void Remove(Topbar topbar)
        {
           _topbarDal.Delete(topbar);
        }

        public void Update(Topbar topbar)
        {
            topbar.CreatedBy = 1;
           topbar.IsActive = true;
            var roworder = _topbarDal.GetActiveList().Count();
           topbar.RowOrder = roworder;
           topbar.LastUpdatedAt = DateTime.Now;
            _topbarDal.Update(topbar);
        }
    }
}
