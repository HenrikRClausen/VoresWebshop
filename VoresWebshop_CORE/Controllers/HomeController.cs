﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VoresWebshop.Models;

namespace VoresWebshop.Controllers {
    public class HomeController : Controller {
        public IActionResult Index() {
            return View();
            }

        public IActionResult About() {
            ViewData["Message"] = "[Vi skriver mere om butikken her.]";

            return View();
            }

        public IActionResult Contact() {
            ViewData["Message"] = "Skriv til VoresWebshop.";

            return View();
            }

        public IActionResult Privacy() {
            return View();
            }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
    }
