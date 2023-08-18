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
    public class CarouselDal : BaseRepository<Carousel, ProjeContext>, ICarouselDal
    {
        public IList<CarouselListDto> GetCarouselListDal()
        {
            using (var context = new ProjeContext())
            {
                var a = context.Carousels.Select(carousel => new CarouselListDto()
                {
                  Id=carousel.Id,
                  CityBranch=carousel.CityBranch,
                  City=carousel.City,
                  CityDescription=carousel.CityDescription,
                  Image=carousel.Image,
                  LastUpdateedAt=carousel.LastUpdatedAt,
                  IsActive=carousel.IsActive,
                  RowOrder=carousel.RowOrder,   
                  CreatedFullName = carousel.User.Name,//ıd yerine name atadık
                });
                return a.ToList();
            }
        }
    }
}
