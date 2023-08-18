using DataAccessLayer.Entities;
using DataAccessLayer.Entities.Dtos.AdminDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public interface ITestimonialManager
    {
        IList<TestimonialListDto> GetTestimonialListManager();
        IList<Testimonial> GetList();
        void Add(Testimonial testimonial);

        void Update(Testimonial testimonial);

        void Remove(Testimonial testimonial);

       Testimonial GetById(int id);



    }
}
