using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Tesisat.ViewComponents
{
    public class NavbarViewComponent:ViewComponent
    {
        private readonly IAboutManager _aboutManager;

        public NavbarViewComponent(IAboutManager aboutManager)
        {
            _aboutManager = aboutManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(_aboutManager.GetNavbarListManager());
        }

    }
}
