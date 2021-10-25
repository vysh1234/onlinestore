using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;

namespace onlineshop.Models
{
    public class yourstore : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
        public string Onlineorder()
        {
            return "All orders Accepted..!";
        }

    }
}
