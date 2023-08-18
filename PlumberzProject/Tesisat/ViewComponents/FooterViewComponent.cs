using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Tesisat.ViewComponents
{
    public class FooterViewComponent:ViewComponent // yeni bir crud işlemleri için dal da ve manager da alanlar oluşturmadık topbarınkini kullanacakz benzer oldukları için alanlar 
    {
        private readonly ITopbarManager _topbarManager;

        public FooterViewComponent(ITopbarManager topbarManager)
        {
            _topbarManager = topbarManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(_topbarManager.GetList());
        }

    }
}
