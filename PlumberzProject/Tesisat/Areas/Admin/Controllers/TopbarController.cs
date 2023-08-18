using BusinessLayer.Abstract;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Tesisat.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class TopbarController : Controller
    {
        private readonly ITopbarManager _topbarManager;

        public TopbarController(ITopbarManager topbarManager)
        {
            this._topbarManager = topbarManager;
        }

        // GET: TopBarController
        public async Task<IActionResult> Index()
        {
            //  var listele = _topbarManager.GetList();
            var listeledto = _topbarManager.GetTopbarListManager();
            return View(listeledto);
        }

        // GET: TopBarController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: TopBarController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Topbar topbar)
        {
            try
            {
                _topbarManager.Add(topbar); 
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TopBarController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var data=_topbarManager.GetById(id);
            return View(data);
        }

        // POST: TopBarController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async  Task<IActionResult> Edit(int id, Topbar topbar)
        {
            try
            {
                _topbarManager.Update(topbar);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TopBarController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var data = _topbarManager.GetById(id);
            return View(data);
        }

        // POST: TopBarController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Topbar topbar)
        {
            try
            {
                _topbarManager.Remove(topbar);  
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
