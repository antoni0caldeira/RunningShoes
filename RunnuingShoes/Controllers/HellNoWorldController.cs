using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunnuingShoes.Controllers
{
    public class HellNoWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
