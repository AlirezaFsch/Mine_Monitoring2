using Microsoft.AspNetCore.Mvc;
using Mine_Monitoring.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mine_Monitoring.Controllers
{
    public class BourseController : Controller
    {
        public IActionResult Index()
        {
            List<BourseModel> stocks = new List<BourseModel>();

            Random random = new Random();

            // List of custom Persian names
            string[] names = {
                "آهن",
                "مس",
                "خودرو",
                "مس کرمان",
                "الومینیوم اراک",
                "معدنی",
                "نفت و گاز",
                "فولاد",
                "پتروشیمی",
                "شیمیایی",
                "بنزین",
                "زغال سنگ",
                "معدن",
                "زراعی",
                "تجاری",
                "دامپروری",
                "صنعت",
                "آبزی پروری",
                "کشاورزی",
                "مرغ"
                // Add more names as needed
            };

            // Shuffle the names array to randomize the order
            Shuffle(names);

            // Ensure only unique names are selected
            List<string> uniqueNames = names.Distinct().Take(20).ToList(); // Select 20 unique names

            for (int i = 0; i < 20; i++)
            {
                // Generate a random value between -5 and +10
                decimal randomValue = (decimal)(random.NextDouble() * 15 - 5); // Adjust range as needed

                // Select a random name from the uniqueNames list
                string randomName = uniqueNames[i];

                // Create a new BourseModel instance
                BourseModel stock = new BourseModel
                {
                    StockName = randomName,
                    Value = Math.Round(randomValue, 2) // Round to 2 decimal places
                };

                stocks.Add(stock);
            }

            return View(stocks);
        }

        // Fisher-Yates shuffle algorithm to shuffle array
        private void Shuffle<T>(T[] array)
        {
            Random random = new Random();
            int n = array.Length;
            for (int i = n - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                T temp = array[j];
                array[j] = array[i];
                array[i] = temp;
            }
        }
    }
}
