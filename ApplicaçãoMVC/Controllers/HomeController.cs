﻿using ApplicaçãoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ApplicaçãoMVC.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            HomeModel home = new HomeModel();
            home.Nome = "Luiz Ricardo";
            home.Email = "Luiz@email.com";

            return View(home);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}