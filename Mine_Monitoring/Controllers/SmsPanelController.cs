using Microsoft.AspNetCore.Mvc;

namespace Mine_Monitoring.Controllers
{
    public class SmsPanelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
