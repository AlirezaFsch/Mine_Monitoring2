using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace MineMonitoringApp.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult GetRandomData()
        {
            var random = new Random();
            var data = new
            {
                DelayedStart = random.NextDouble() * 50,
                DelayedFinish = random.NextDouble() * 50,
                ManHours = random.Next(1000, 5000),
                ManHoursComparison = random.NextDouble() * 10,
                MonthlyData = Enumerable.Range(1, 12).Select(_ => random.Next(100, 500)).ToArray(),
                WorkOrderComparison = random.NextDouble() * 20
            };
            return Json(data);
        }
    }
}
