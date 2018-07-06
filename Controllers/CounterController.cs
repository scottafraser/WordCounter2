using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WordCount2.Models;

namespace WordCount2.Controllers
{
    public class CounterController : Controller
    {
     
        [HttpGet("/begin")]
        public ActionResult Index()
        {
            
            return View();
        }

        [HttpGet("/results")]
        public ActionResult Result()
        {

            return View();
        }

        //[HttpPost("/results")]
        //public ActionResult ResultPost()
        //{
        //    RepeatCounter newWordOne = new RepeatCounter(Request.Form["word-one"]);
        //    //List<RepeatCounter> newWord = RepeatCounter.GetAll();
           
        //    return View("Result", newWordOne);
        //}



    }
}
