using BusinessLayer.Abstract;
using DataAccessLayer;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Tesisat.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
  //  [Authorize]// giriş olmadan bu controllera erişilemez anlamında 
    public class BookingController : Controller
    {
        private readonly IBookingManager _bookingManager;

        public BookingController(IBookingManager bookingManager)
        {
            _bookingManager = bookingManager;
        }

        // GET: BookingController
        public async Task<IActionResult> Index()
        {
            // var listele = _bookingManager.GetList();
            var dtolistele = _bookingManager.GetBookingListManager();
            return View(dtolistele);
        }

        // GET: BookingController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: BookingController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Booking booking)
        {
            try
            {
                _bookingManager.Add(booking);   
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookingController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var listele=_bookingManager.GetById(id);    
            return View(listele);
        }

        // POST: BookingController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Booking booking)
        {
            try
            {
                _bookingManager.Update(booking);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookingController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var listele = _bookingManager.GetById(id);
            return View(listele);
        }

        // POST: BookingController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Booking booking)
        {
            try
            {
                _bookingManager.Remove(booking);    
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
