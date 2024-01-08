using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Abstract.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class UserController : Controller
    {
        UserManager um = new UserManager(new EfUserRepository());



        public IActionResult Index()
        {
            return View();
        }
    }
}