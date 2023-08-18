using BusinessLayer.Abstract;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Tesisat.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    // [Authorize]// giriş olmadan bu controllera erişilemez anlamında 
    [AllowAnonymous]
    public class AboutController : Controller
    {

        private readonly IAboutManager _aboutManager;

        public AboutController(IAboutManager aboutManager)
        {
            _aboutManager = aboutManager;
        }

        // GET: AboutController
        public async Task<IActionResult> Index()
        {

            // var list =  _aboutManager.GetList();
     
           var listele = _aboutManager.GetAboutListManager();
            return View(listele);
        }

        // GET: AboutController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: AboutController/Create
    
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(About about, IFormFile? İmage1, IFormFile? İmage2)
        {
            try
            {
                //switch case olmadı
                if (!ModelState.IsValid)
                {
   
                    if (İmage1  is not null)
                    {
                        string klasor1 = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + İmage1.FileName;
                        using var stream1 = new FileStream(klasor1, FileMode.Create);
                        İmage1.CopyTo(stream1);
                        about.İmage1 = İmage1.FileName;
                    }
                    if (İmage2 is not null)
                    {
                        string klasor2 = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + İmage2.FileName;
                        using var stream2 = new FileStream(klasor2, FileMode.Create);
                        İmage2.CopyTo(stream2);
                        about.İmage2 = İmage2.FileName;
                    }
                    _aboutManager.Add(about);
                }
                
                return RedirectToAction(nameof(Index));


            }
            catch
            {
                return View();
            }
        }

        // GET: AboutController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var list = _aboutManager.GetById(id);
            return View(list);
        }

        // POST: AboutController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, About about, IFormFile? İmage1, IFormFile? İmage2)
        {
            try
            {
                if (!ModelState.IsValid)
                {

                    if (İmage1 is not null)
                    {
                        string klasor1 = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + İmage1.FileName;
                        using var stream1 = new FileStream(klasor1, FileMode.Create);
                        İmage1.CopyTo(stream1);
                        about.İmage1 = İmage1.FileName;
                    }
                    if (İmage2 is not null)
                    {
                        string klasor2 = Directory.GetCurrentDirectory() + "/wwwroot/Img/" + İmage2.FileName;
                        using var stream2 = new FileStream(klasor2, FileMode.Create);
                        İmage2.CopyTo(stream2);
                        about.İmage2 = İmage2.FileName;
                    }
                    _aboutManager.Update(about);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AboutController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var list = _aboutManager.GetById(id);
            return View(list);
        }

        // POST: AboutController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, About about)
        {
            try
            {
                _aboutManager.Remove(about);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
