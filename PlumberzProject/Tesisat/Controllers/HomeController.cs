using BusinessLayer.Abstract;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tesisat.Models;

namespace Tesisat.Controllers
{
  //  [Authorize]
    public class HomeController : Controller
    {
        private readonly ITopbarManager _topbarManager;
        private readonly IAboutManager _aboutManager;
        private readonly ICarouselManager _carouselManager;
        private readonly IServiceManager _serviceManager;
        private readonly IBookingManager _bookingManager;
        private readonly IContactManager _contactManager;

        public HomeController(ITopbarManager topbarManager, IAboutManager aboutManager, ICarouselManager carouselManager, IServiceManager serviceManager, IBookingManager bookingManager, IContactManager contactManager)
        {
            _topbarManager = topbarManager;
            _aboutManager = aboutManager;
            _carouselManager = carouselManager;
            _serviceManager = serviceManager;
            _bookingManager = bookingManager;
            _contactManager = contactManager;
        }



        public async Task<IActionResult> Anasayfa()
        {
          
            return View();
        }

        public async Task<IActionResult> Index()//Topbar
        {
            var listele = _topbarManager.GetList();
            return View(listele);
        }

        public async Task<IActionResult> About()
        {
            var listele=_aboutManager.GetList();
            return View(listele);
        }

        public async Task<IActionResult> Navbar()//about üzerinde  çektik navbar verilerini
        {
            var listele = _aboutManager.GetNavbarListManager();
            return View(listele);
        }

        public async Task<IActionResult> Slayder()
        {
            var listele =_carouselManager.GetList();
            return View(listele);
        }




        public async Task<IActionResult> Fact() //Bunda index üzerinden listeleme olmayacak
        {
            return View();
        }

        public async Task<IActionResult> Service() 
        {
            var listele=_serviceManager.GetList();  
            return View(listele);
        }

        [HttpGet]
        public async Task<IActionResult> Booking()
        {
          
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Booking(Booking booking)
        {
            _bookingManager.Add(booking);
            return Ok("Rezervasyon başarılı bir şekilde oluşturuldu");
        }



        public async Task<IActionResult> Team()// viewcomponente listteleme yaptıında controllerda yapmana gerek yok
        {

            return View();
        }

        public async Task<IActionResult> Testimonial()
        {
            return View();  
        }

        public async Task<IActionResult> Footer()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Contact()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Contact(Contact contact)
        {

            _contactManager.Add(contact);
            return Ok("mesaj başarılı bir şekilde gönderildi");
        }

    }
}