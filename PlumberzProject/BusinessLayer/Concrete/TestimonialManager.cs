using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Entities;
using DataAccessLayer.Entities.Dtos.AdminDtos;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialManager
    {

        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void Add(Testimonial testimonial)
        {
            testimonial.CreatedBy = 1;
            testimonial.IsActive = true;
            var roworder = _testimonialDal.GetActiveList().Count();
            testimonial.RowOrder = roworder + 1;
            _testimonialDal.Add(testimonial);
        }

        public Testimonial GetById(int id)
        {
            Expression<Func<Testimonial, bool>> filter = x => x.Id == id;
            return _testimonialDal.Get(filter);
        }

        public IList<Testimonial> GetList()
        {
            var listele = _testimonialDal.GetActiveList();
            return listele;
        }

        public IList<TestimonialListDto> GetTestimonialListManager()
        {
            var listdto = _testimonialDal.GetTestimonialListDal();
            return listdto;                         
        }

        public void Remove(Testimonial testimonial)
        {
            _testimonialDal.Delete(testimonial);    
        }

        public void Update(Testimonial testimonial)
        {
            testimonial.CreatedBy = 1;
           testimonial.IsActive = true;
            var roworder = _testimonialDal.GetActiveList().Count();
            testimonial.RowOrder = roworder;
            testimonial.LastUpdatedAt = DateTime.Now;
            _testimonialDal.Update(testimonial);
        }
    }
}
