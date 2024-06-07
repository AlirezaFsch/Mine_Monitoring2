using Microsoft.AspNetCore.Mvc;

namespace Mine_Monitoring.Controllers
{
    public class BourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
