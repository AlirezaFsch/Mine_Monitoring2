using Microsoft.AspNetCore.Mvc;
using Mine_Monitoring.Models;
using System.Collections.Generic;

namespace Mine_Monitoring.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            // Hardcoded users
            List<Users> users = new List<Users>
            {
                new Users { Id = 1, Name = "John Doe", PhoneNumber = "1234567890" },
                new Users { Id = 2, Name = "Jane Smith", PhoneNumber = "9876543210" }
                // Add more users as needed
            };

            return View(users);
        }
    }
}
