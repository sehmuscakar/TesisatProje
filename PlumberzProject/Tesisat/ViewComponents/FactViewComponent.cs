using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Tesisat.ViewComponents
{
    public class FactViewComponent:ViewComponent
    {
        private readonly IFactManager _factManager;

        public FactViewComponent(IFactManager factManager)
        {
            _factManager = factManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = _factManager.GetList();
            return View(listele);
        }


    }
}
