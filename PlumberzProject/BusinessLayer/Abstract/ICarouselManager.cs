using DataAccessLayer.Entities;
using DataAccessLayer.Entities.Dtos.AdminDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICarouselManager
    {
        IList<CarouselListDto> GetCarouselListManager();
        IList<Carousel> GetList();
        void Add(Carousel carousel);

        void Update(Carousel carousel);

        void Remove(Carousel carousel);

        Carousel GetById(int id);
    }
}
