using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Tesisat.ViewComponents
{
    public class TestimonialViewComponent:ViewComponent
    {
        private readonly ITestimonialManager _testimonialManager;

        public TestimonialViewComponent(ITestimonialManager testimonialManager)
        {
            _testimonialManager = testimonialManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = _testimonialManager.GetList();
            return View(listele);
        }
    }
}
