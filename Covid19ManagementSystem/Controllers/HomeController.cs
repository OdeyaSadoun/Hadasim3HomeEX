﻿using Microsoft.AspNetCore.Mvc;

namespace Covid19ManagementSystem.Controllers
{

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddMember()
        {
            return View();
        }

        public IActionResult HmoMembers()
        {
            return View();
        }

        public IActionResult Statistics()
        {
            return View();
        }
    }
}
