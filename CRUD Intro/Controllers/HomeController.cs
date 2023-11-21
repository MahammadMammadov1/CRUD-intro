using CRUD_Intro.DAL;
using CRUD_Intro.Models;
using CRUD_Intro.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;

namespace CRUD_Intro.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _logger;

        public HomeController(AppDbContext logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();
            model.Services=_logger.Services.ToList();

            return View(model);
        }

        
    }
}