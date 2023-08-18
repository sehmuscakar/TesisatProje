using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Tesisat.ViewComponents
{
    public class CarouselViewComponent:ViewComponent
    {

        private readonly ICarouselManager _carouselManager;

        public CarouselViewComponent(ICarouselManager carouselManager)
        {
            _carouselManager = carouselManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(_carouselManager.GetList());
        }
    }
}
