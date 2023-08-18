using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Tesisat.ViewComponents
{
    public class TopbarViewComponent:ViewComponent
    {

        private readonly ITopbarManager _topbarManager;

        public TopbarViewComponent(ITopbarManager topbarManager)
        {
            _topbarManager = topbarManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(_topbarManager.GetList());
        }
    }
}
