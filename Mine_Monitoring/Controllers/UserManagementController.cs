using Microsoft.AspNetCore.Mvc;
using Mine_Monitoring.Models;
using System.Collections.Generic;
using System.Linq;
using Mine_Monitoring.Models;

namespace Mine_Monitoring.Controllers
{
    public class UserManagementController : Controller
    {
        private static List<User> users = new List<User>
        {
            new User { Id = 1, UserName = "مدیرکل", Email = "admin@example.com", UserType = "admin" },
            new User { Id = 2, UserName = "کاربر", Email = "user@example.com", UserType = "user" },
            new User { Id = 3, UserName = "ستاد", Email = "setad@example.com", UserType = "setad" },
            new User { Id = 4, UserName = "مدیر", Email = "manager@example.com", UserType = "manager" }
        };

        public IActionResult Index()
        {
            return View(users);
        }

        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                user.Id = users.Max(u => u.Id) + 1;
                users.Add(user);
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        public IActionResult EditUser(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        public IActionResult Edit(int id, User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var existingUser = users.FirstOrDefault(u => u.Id == id);
                if (existingUser != null)
                {
                    existingUser.UserName = user.UserName;
                    existingUser.Email = user.Email;
                    existingUser.UserType = user.UserType;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }
    }
}
