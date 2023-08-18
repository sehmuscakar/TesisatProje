using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Tesisat.ViewComponents
{
    public class TeamViewComponent:ViewComponent
    {
        private readonly ITeamManager _teamManager;

        public TeamViewComponent(ITeamManager teamManager)
        {
            _teamManager = teamManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listele = _teamManager.GetList();
            return View(listele);
        }

    }
}
