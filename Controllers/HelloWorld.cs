﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace onlineshop.Controllers
{
    public class HelloWorld : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult clothes()
        {
            return View();
        }

    }
}
