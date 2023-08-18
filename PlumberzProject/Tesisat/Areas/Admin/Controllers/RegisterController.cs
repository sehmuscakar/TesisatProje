using BusinessLayer.Abstract;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Tesisat.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class RegisterController : Controller
    {
        private readonly IRegisterManager _registerManager;

        public RegisterController(IRegisterManager registerManager)
        {
            _registerManager = registerManager;
        }

        // GET: RegisterController
        public async Task<IActionResult> Index()
        {
            var listele = _registerManager.GetList();
            return View(listele);
        }

        // GET: RegisterController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: RegisterController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(User user)// kendisi layot olarak kullandık register formu var burda ekleme burdan oluyor
        {
            try
            {
                _registerManager.Add(user);
                return RedirectToAction("Signİn","Login");
            }
            catch
            {
                return View();
            }
        }

        // GET: RegisterController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var listele=_registerManager.GetById(id);   
            return View(listele);
        }

        // POST: RegisterController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, User user)
        {
            try
            {
                _registerManager.Update(user);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RegisterController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var listele = _registerManager.GetById(id);
            return View(listele);
        }

        // POST: RegisterController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, User user)
        {
            try
            {
                _registerManager.Remove(user);  
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
