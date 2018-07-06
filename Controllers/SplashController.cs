using System;
using Microsoft.AspNetCore.Mvc;
using WordCount2.Models;

namespace WordCount2.Controllers
{
    public class SplashController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }


    }
}