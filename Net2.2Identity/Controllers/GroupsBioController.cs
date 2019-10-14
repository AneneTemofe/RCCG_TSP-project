using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RCCG_TSP_CRM.Controllers
{
    public class GroupsBioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Women()
        {
            return View();
        }

        public IActionResult Youths()
        {
            return View();
        }

        public IActionResult Teenagers()
        {
            return View();
        }

        public IActionResult Children()
        {
            return View();
        }

        
    }
}