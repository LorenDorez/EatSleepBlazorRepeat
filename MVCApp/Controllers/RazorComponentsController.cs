using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCApp.Models;

namespace MVCApp.Controllers
{
    public class RazorComponentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Counter()
        {
            return View();
        }
    }
}
