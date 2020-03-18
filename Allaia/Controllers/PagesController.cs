using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Allaia.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Help()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}