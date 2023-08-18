using BusinessLayer.Abstract;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Tesisat.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class FactController : Controller
    {
        private readonly IFactManager _factManager;

        public FactController(IFactManager factManager)
        {
            _factManager = factManager;
        }

        public async Task<IActionResult> Index()
        {
            //    var listele = _factManager.GetList();
            var listeledto = _factManager.GetFactListManager();
            return View(listeledto);
        }

        // GET: FactController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: FactController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Fact fact)
        {
            try
            {
                _factManager.Add(fact);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FactController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var listele=_factManager.GetById(id);
            return View(listele);
        }

        // POST: FactController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Fact fact)
        {
            try
            {_factManager.Update(fact);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FactController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var listele = _factManager.GetById(id);
            return View(listele);
        }

        // POST: FactController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Fact fact)
        {
            try
            {
                _factManager.Remove(fact);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
