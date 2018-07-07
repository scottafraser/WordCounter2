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


        [HttpGet("/index")]
        public ActionResult InputList()
        {
            Item word = new Item(Request.Query["word-one"]);

            return View(word);
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
