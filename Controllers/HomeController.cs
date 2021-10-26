using Microsoft.AspNetCore.Mvc;
using MyCityPlan_Demo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCityPlan_Demo.Controllers
{
    public class HomeController : Controller
    {
      
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
