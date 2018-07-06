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


        [HttpPost("/result")]
        public ActionResult Result()
        {
            RepeatCounter forms = new RepeatCounter();
            forms.SetStringOne(Request.Query["word-one"]);
            forms.SetStringTwo(Request.Query["list-words"]);

            return View(forms);
        }




        //[HttpPost("/result")]
        //public ActionResult Post()
        //{
        //    RepeatCounter forms = new RepeatCounter();
        //    forms.GetStringOne();
        //    forms.GetStringTwo();
           

        //    return View("Result", forms);
        //}

        //[HttpPost("/result")]
        //public ActionResult ResultPost()
        //{
        //    RepeatCounter forms = new RepeatCounter(word, words);

        //    return View(forms);

        //}
    }
}
