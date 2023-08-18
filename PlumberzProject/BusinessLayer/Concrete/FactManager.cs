using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Entities;
using DataAccessLayer.Entities.Dtos.AdminDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class FactManager : IFactManager
    {

        private readonly IFactDal _factDal;

        public FactManager(IFactDal factDal)
        {
            _factDal = factDal;
        }

        public void Add(Fact fact)
        {
            fact.CreatedBy = 1;
            fact.IsActive = true;
            var roworder = _factDal.GetActiveList().Count();
            fact.RowOrder = roworder + 1;
            _factDal.Add(fact);
        }

        public Fact GetById(int id)
        {
            Expression<Func<Fact, bool>> filter = x => x.Id == id;
            return _factDal.Get(filter);
        }

        public IList<FactListDto> GetFactListManager()
        {
            var listeledto = _factDal.GetFactListDal();
            return listeledto;  
        }

        public IList<Fact> GetList()
        {
            var list = _factDal.GetActiveList();
            return list;
        }

        public void Remove(Fact fact)
        {
           _factDal.Delete(fact);   
        }

        public void Update(Fact fact)
        {
           fact.CreatedBy = 1;
           fact.IsActive = true;
            var roworder = _factDal.GetActiveList().Count();
            fact.RowOrder = roworder;
            fact.LastUpdatedAt = DateTime.Now;
            _factDal.Update(fact);   
        }
    }
}
