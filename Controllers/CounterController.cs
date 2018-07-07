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
            if (word.CorrectInput(string1) == true && word.CorrectInputTwo(string2) == true) 
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

     
        
    }
}
