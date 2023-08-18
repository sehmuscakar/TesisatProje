using BusinessLayer.Abstract;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Tesisat.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    //[Authorize]// giriş olmadan bu controllera erişilemez anlamında 
    public class ServiceController : Controller
    {
        private readonly IServiceManager _serviceManager;

        public ServiceController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        // GET: ServiceController
        public async Task<IActionResult> Index()
        {
           var listele= _serviceManager.GetServiceListManager();

            return View(listele);
        }


        // GET: ServiceController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: ServiceController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Service service)
        {
            try
            {
              //  service.User.Id = 3;
                _serviceManager.Add(service);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ServiceController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var listele=_serviceManager.GetById(id);    
            return View(listele);
        }

        // POST: ServiceController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Service service)
        {
            try
            {
                _serviceManager.Update(service);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ServiceController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var listele = _serviceManager.GetById(id);
            return View(listele);
        }

        // POST: ServiceController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Service service)
        {
            try
            {
                _serviceManager.Remove(service);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
