using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyCityPlan_Demo.Data;
using MyCityPlan_Demo.Models;

namespace MyCityPlan_Demo.Controllers
{
    public class HomeController : Controller
    {
        

        // GET: /Hello/index/ another index
        // GET: Benutzers
      
        public IActionResult Index()
        {
            return View();
        }
    }
}
