﻿using System;
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


        [HttpPost("/inputlist")]
        public ActionResult InputList()
        {
            Item word =new Item();
            word.SetStringOne(Request.Form["word-one"]);
            
            return View(word);
        }

        [HttpGet("/listForm")]
        public ActionResult Result()
        {
            //Item words = new Item);

            return View();
        }

        //[HttpGet("/result")]




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
