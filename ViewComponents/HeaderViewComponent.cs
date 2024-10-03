using Microsoft.AspNetCore.Mvc;

namespace Freelancer.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
