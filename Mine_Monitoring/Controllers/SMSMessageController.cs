using Microsoft.AspNetCore.Mvc;
using Mine_Monitoring.Models;
using System;
using System.Collections.Generic;

namespace Mine_Monitoring.Controllers
{
    public class SMSMessageController : Controller
    {
        private readonly List<SMSMessage> _sentMessages = new List<SMSMessage>();

        public IActionResult Index()
        {
            return View(_sentMessages);
        }

        [HttpGet]
        public IActionResult Send()
        {
            ViewBag.Users = GetUsers(); // Fetch users for dropdown
            ViewBag.SMSTypes = GetSMSTypes(); // Fetch SMS types for dropdown
            return View();
        }

        [HttpPost]
        public IActionResult Send(int userId, int smsTypeId, string message)
        {
            var user = GetUsers().Find(u => u.Id == userId);
            var smsType = GetSMSTypes().Find(s => s.Id == smsTypeId);

            var newSMS = new SMSMessage
            {
                Id = _sentMessages.Count + 1,
                UserId = userId,
                User = user,
                SMSTypeId = smsTypeId,
                SMSType = smsType,
                Message = message,
                SentDateTime = DateTime.Now
            };

            _sentMessages.Add(newSMS);

            return RedirectToAction("Index");
        }

        // Simulated data retrieval methods
        private List<Users> GetUsers()
        {
            return new List<Users>
            {
                new Users { Id = 1, Name = "John Doe", PhoneNumber = "1234567890" },
                new Users { Id = 2, Name = "Jane Smith", PhoneNumber = "9876543210" }
                // Add more users as needed
            };
        }

        private List<SMSType> GetSMSTypes()
        {
            return new List<SMSType>
            {
                new SMSType { Id = 1, TypeName = "Promotional" },
                new SMSType { Id = 2, TypeName = "Transactional" }
                // Add more SMS types as needed
            };
        }
    }
}
