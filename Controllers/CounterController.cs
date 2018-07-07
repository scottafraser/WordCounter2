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


        [HttpPost("/inputlist")]
        public ActionResult InputList()
        {
            Item word =new Item();
            word.SetStringOne(Request.Form["word-one"]); 
            word.SetStringTwo(Request.Form["list-words"]);
            string string1 = word.GetStringOne();
            string string2 = word.GetStringTwo();
                if (word.CorrectInput(string1) == true) 
            {
                string[] array = word.splitWord(string2);
                word.SetVarX(word.CheckString(array));
            }
            else
            {
                return View("Error");  
            }

            return View(word);
        }



        //[HttpPost("/result")]
        //public ActionResult Result()
        //{
        //    Item words = new Item();
        //    words.GetStringOne();
        //    words.SetStringTwo(Request.Form["list-words"]);
            

        //    return View(words);
        //}

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
