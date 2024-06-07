using Microsoft.AspNetCore.Mvc;
using Mine_Monitoring.Models;
using System;
using System.Collections.Generic;

namespace Mine_Monitoring.Controllers
{
    public class HseController : Controller
    {
        private static List<HseCourse> courses = new List<HseCourse>
        {
                new HseCourse { Id = 1, CourseName = "آموزش ایمنی", Instructor = "محمد حسینی", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(5), Location = "اتاق 101" },
                new HseCourse { Id = 2, CourseName = "کمک‌های اولیه", Instructor = "سارا احمدی", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(2), Location = "اتاق 102" },
                new HseCourse { Id = 3, CourseName = "مدیریت بحران", Instructor = "علی رضایی", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(3), Location = "اتاق 103" },
                new HseCourse { Id = 4, CourseName = "آموزش آتش‌نشانی", Instructor = "زهرا کاظمی", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(4), Location = "اتاق 104" },
                new HseCourse { Id = 5, CourseName = "ایمنی محیط کار", Instructor = "حسن نصیری", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(6), Location = "اتاق 105" },
                new HseCourse { Id = 6, CourseName = "آموزش حوادث صنعتی", Instructor = "فرهاد قاسمی", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(5), Location = "اتاق 106" },
                new HseCourse { Id = 7, CourseName = "ایمنی در معدن", Instructor = "مهسا کریمی", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(7), Location = "اتاق 107" },
                new HseCourse { Id = 8, CourseName = "آموزش حفاظت فردی", Instructor = "رضا موسوی", StartDate = DateTime.Now, EndDate = DateTime.Now.AddDays(3), Location = "اتاق 108" }
        };

        public IActionResult Index()
        {
            return View(courses);
        }

        public IActionResult AddCourse()
        {
            return View();
        }
    }
}
