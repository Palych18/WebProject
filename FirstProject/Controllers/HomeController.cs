using FirstProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProject.Controllers
{
    public class HomeController : Controller
    {
       
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            string viewModel = hour < 18 ? "Добрый день" : "Добрый вечер";

            return View("MyView", viewModel);
        }
    }
}
