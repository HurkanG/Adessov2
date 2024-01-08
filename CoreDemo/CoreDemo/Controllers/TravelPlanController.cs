using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Abstract.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class TravelPlanController : Controller
    {
        TravelPlanManager tpm = new TravelPlanManager(new EfTravelPlanRepository());

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BlogDetails(int id)
        {

            return View();
        }
    }
}