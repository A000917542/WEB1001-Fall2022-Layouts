using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.IO.MemoryMappedFiles;
using WEB1001_Fall2022_Layouts.Models;

namespace WEB1001_Fall2022_Layouts.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        // Data Binding
        // [FromQuery(Name = "first")] double? left, [FromQuery(Name = "second")] double? right

        [FromQuery(Name = "left")]
        public double? left { get; set; }

        [FromQuery(Name = "right")]
        public double? right { get; set; }

        public IActionResult Test()
        {
            //double? left = null;
            //double? right = null;

            //// Fill in Left and Right
            //if (Request.QueryString.HasValue)
            //{
            //    string query = Request?.QueryString.Value?.Replace("?", "") ?? String.Empty;
            //    string[] keyValues = query.Split("&");
            //    string[][] mappedValues = keyValues.Select(i => i.Split("=")).ToArray();

            //    if (mappedValues.Length == 2)
            //    {
            //        left = double.Parse(mappedValues[0][1]);
            //        right = double.Parse(mappedValues[1][1]);
            //    }

            //    // left=12 --- right=54
            //}


            double? result = null;

            // Calculate Response
            if (left.HasValue && right.HasValue)
            {
                result = left + right;
            }
            else
            {
                result = null;
            }


            return View(result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}