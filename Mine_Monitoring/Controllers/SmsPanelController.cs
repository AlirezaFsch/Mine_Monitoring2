using Microsoft.AspNetCore.Mvc;
using Mine_Monitoring.Models;
using System.Collections.Generic;

namespace Mine_Monitoring.Controllers
{
    public class SmsPanelController : Controller
    {
        public IActionResult Index()
        {
            // Simulated data for demonstration
            List<Users> users = new List<Users>
            {
                new Users { Id = 1, Name = "جان دو", PhoneNumber = "1234567890" },
                new Users { Id = 2, Name = "مریم خانم", PhoneNumber = "9876543210" },
                new Users { Id = 3, Name = "علی رضا", PhoneNumber = "5551234567" },
                new Users { Id = 4, Name = "ناصر محمدی", PhoneNumber = "4449876543" },
                new Users { Id = 5, Name = "زهرا احمدی", PhoneNumber = "6665554444" },
                // Add more users with Persian names as needed
            };

            return View(users); // Pass users list to the view
        }
    }
}
