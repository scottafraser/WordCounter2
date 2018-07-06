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
            RepeatCounter words = new RepeatCounter();
            words.SetStringOne(Request.Form["word-one"]);
            words.SetStringTwo(Request.Form["list-words"]);
            return View(words);
           
        }

        [HttpPost("/results")]
        public ActionResult ResultPost()
        {
            
            RepeatCounter words = new RepeatCounter();
            words.GetStringOne();
            words.GetStringTwo();
            return View(words);

        }



    }
}
