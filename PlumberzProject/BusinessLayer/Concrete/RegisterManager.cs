using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Entities;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class RegisterManager : IRegisterManager
    {
        private readonly IRegisterDal _registerDal;

        public RegisterManager(IRegisterDal registerDal)
        {
            _registerDal = registerDal;
        }

        public void Add(User user)  
        {
        
            user.IsActive = true;
            var roworder = _registerDal.GetActiveList().Count();
            user.RowOrder = roworder + 1;
            _registerDal.Add(user); 
        }

        public User GetById(int id)
        {
            Expression<Func<User, bool>> filter = x => x.Id == id;
            return _registerDal.Get(filter);
        }

        public IList<User> GetList()
        {
            var listele = _registerDal.GetActiveList();
            return listele; 
                 
        }

        public void Remove(User user)
        {
            _registerDal.Delete(user);  
        }

        public void Update(User user)
        {
            user.IsActive = true;
            var roworder = _registerDal.GetActiveList().Count();
            user.RowOrder = roworder;
            _registerDal.Update(user);    
        }
    }
}
