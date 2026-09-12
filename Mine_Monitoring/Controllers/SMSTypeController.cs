using Microsoft.AspNetCore.Mvc;
using Mine_Monitoring.Models;
using System.Collections.Generic;

namespace Mine_Monitoring.Controllers
{
    public class SMSTypeController : Controller
    {
        public IActionResult Index()
        {
            // Hardcoded SMS types
            List<SMSType> smsTypes = new List<SMSType>
            {
                new SMSType { Id = 1, TypeName = "Promotional" },
                new SMSType { Id = 2, TypeName = "Transactional" }
                // Add more SMS types as needed
            };

            return View(smsTypes);
        }
    }
}
