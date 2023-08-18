using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Entities;
using DataAccessLayer.Entities.Dtos.AdminDtos;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class CarouselManager : ICarouselManager
    {

        private readonly ICarouselDal _carouselDal;

        public CarouselManager(ICarouselDal carouselDal)
        {
            _carouselDal = carouselDal;
        }

        public void Add(Carousel carousel)
        {
            carousel.CreatedBy = 1;
            carousel.IsActive = true;
            var roworder = _carouselDal.GetActiveList().Count();
            carousel.RowOrder = roworder + 1;    
            _carouselDal.Add(carousel);
        }

        public Carousel GetById(int id)
        {
            Expression<Func<Carousel, bool>> filter = x => x.Id == id;
            return _carouselDal.Get(filter);
        }

        public IList<CarouselListDto> GetCarouselListManager()
        {
            var listedto = _carouselDal.GetCarouselListDal();
            return listedto;    
        }

        public IList<Carousel> GetList()
        {
            var listele = _carouselDal.GetActiveList();
            return listele;
        }

        public void Remove(Carousel carousel)
        {
           _carouselDal.Delete(carousel);   
        }

        public void Update(Carousel carousel)
        {

           carousel.CreatedBy = 1;
           carousel.IsActive = true;
            var roworder = _carouselDal.GetActiveList().Count();
            carousel.RowOrder = roworder;
           carousel.LastUpdatedAt = DateTime.Now;
            _carouselDal.Update(carousel);
        }
    }
}
