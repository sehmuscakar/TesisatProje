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
    public class TestimonialDal : BaseRepository<Testimonial, ProjeContext>, ITestimonialDal
    {
        public IList<TestimonialListDto> GetTestimonialListDal()
        {
            using (var context = new ProjeContext())
            {
                var a = context.Testimonials.Select(testimonial => new TestimonialListDto()
                {
                    Id = testimonial.Id,
                    Image = testimonial.Image,
                Decsription=testimonial.Decsription,
                FullNnme=testimonial.FullNnme,
                Profession=testimonial.Profession,
                star=testimonial.star,
                    LastUpdateedAt = testimonial.LastUpdatedAt,
                    CreatedFullName = testimonial.User.Name,//bunu about user ilişkisinden userdan çektik
                    IsActive = testimonial.IsActive,
                    RowOrder = testimonial.RowOrder
                });
                return a.ToList();
            }
        }
    }
}
