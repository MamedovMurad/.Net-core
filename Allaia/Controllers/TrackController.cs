﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Allaia.Controllers
{
    public class TrackController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}