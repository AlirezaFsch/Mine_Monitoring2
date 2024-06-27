using Microsoft.AspNetCore.Mvc;
using Mine_Monitoring.Models;

namespace Mine_Monitoring.Controllers
{
    public class BourseController : Controller
    {
        public IActionResult Index()
        {
            // Hardcoded stock data
            List<BourseModel> stocks = new List<BourseModel>()
        {
            new BourseModel { StockName = "Stock 1", Value = 25.78m },
            new BourseModel { StockName = "Stock 2", Value = -12.45m },
            new BourseModel { StockName = "Stock 3", Value = 0.00m },
            // Add more stocks as needed
        };

            return View(stocks);
        }
    }
}
