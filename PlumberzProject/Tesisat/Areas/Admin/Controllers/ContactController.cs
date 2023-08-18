﻿using BusinessLayer.Abstract;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Tesisat.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
   // [Authorize]// giriş olmadan bu controllera erişilemez anlamında 

    public class ContactController : Controller
    {
        private readonly IContactManager _contactManager;

        public ContactController(IContactManager contactManager)
        {
            _contactManager = contactManager;
        }

        // GET: ContactController
        public async Task<IActionResult> Index()
        {
            //   var listele = _contactManager.GetList();
            var listdto = _contactManager.GetContactListManager();
            return View(listdto);
        }

        // GET: ContactController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: ContactController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Contact contact)
        {
            try
            {
                _contactManager.Add(contact);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ContactController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var listele = _contactManager.GetById(id);
            return View(listele);
        }

        // POST: ContactController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Contact contact)
        {
            try
            {_contactManager.Update(contact);   
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ContactController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var listele = _contactManager.GetById(id);
            return View(listele);
        }

        // POST: ContactController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id, Contact contact)
        {
            try
            {
                _contactManager.Remove(contact);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
