using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Tesisat.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class CarouselController : Controller
    {
        private readonly ICarouselManager _carouselManager;

        public CarouselController(ICarouselManager carouselManager)
        {
            _carouselManager = carouselManager;
        }

        public async Task<IActionResult> Index()
        {
            //  var listele= _carouselManager.GetList();
            var listeledto = _carouselManager.GetCarouselListManager();
            return View(listeledto);
        }


        // GET: CarouselController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: CarouselController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Carousel carousel, IFormFile? Image)
        {
            try
            {

                if (!ModelState.IsValid)
                {
                    if (Image is not null)
                    {
                        string klasor1 = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + Image.FileName;
                        using var stream1 = new FileStream(klasor1, FileMode.Create);
                        Image.CopyTo(stream1);
                        carousel.Image = Image.FileName;
                    }
                    _carouselManager.Add(carousel);
                }
             
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CarouselController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var list = _carouselManager.GetById(id);
            return View(list);
        }

        // POST: CarouselController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Carousel carousel, IFormFile? Image)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    if (Image is not null)
                    {
                        string klasor1 = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + Image.FileName;
                        using var stream1 = new FileStream(klasor1, FileMode.Create);
                        Image.CopyTo(stream1);
                        carousel.Image = Image.FileName;
                    }
                    _carouselManager.Update(carousel);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CarouselController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var list = _carouselManager.GetById(id);
            return View(list);
        }

        // POST: CarouselController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Carousel carousel)
        {
            try
            {
                _carouselManager.Remove(carousel);  
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
