using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Mine_Monitoring.Models;

namespace Mine_Monitoring.Controllers
{
    public class SystemManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SysUsers()
        {
            // Mocking system users data
            var sysUsers = new List<SysUser>
            {
                new SysUser { Id = "1", FullName = "کاربر سیستم ۱", Username = "sysuser1", Email = "sysuser1@example.com", PhoneNumber = "۰۹۱۲۳۴۵۶۷۸۹", Role = "مدیر" },
                new SysUser { Id = "2", FullName = "کاربر سیستم ۲", Username = "sysuser2", Email = "sysuser2@example.com", PhoneNumber = "۰۹۹۹۸۷۶۵۴۳۲", Role = "کاربر" },
                new SysUser { Id = "3", FullName = "کاربر سیستم ۳", Username = "sysuser3", Email = "sysuser3@example.com", PhoneNumber = "۰۹۳۷۶۵۴۳۲۱", Role = "کاربر" },
                new SysUser { Id = "4", FullName = "کاربر سیستم ۴", Username = "sysuser4", Email = "sysuser4@example.com", PhoneNumber = "۰۹۱۲۳۴۵۶۷۸۹", Role = "کاربر" },
                new SysUser { Id = "5", FullName = "کاربر سیستم ۵", Username = "sysuser5", Email = "sysuser5@example.com", PhoneNumber = "۰۹۹۹۸۷۶۵۴۳۲", Role = "مدیر" },
                // Add more system users as needed
            };

            return View(sysUsers);
        }
    }
}
