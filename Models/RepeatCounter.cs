using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;


namespace WordCount2.Models
{
    public class Item
    {
        //private  static List<Item> _userstring2 = new List<Item>;
        public  string _userString1;
        public string _userString2;
        public  int _x;



        //public Item (string userWord)
        //{
        //    _userString1 = userWord;
        //    //_userString2 = new List<Item>;
        //    _x = 0; 

        //}

        public void SetStringOne(string word)
        {
            _userString1 = word;
            //_userString1 = word.ToLower();
        }

        public string GetStringOne()
        {
            return _userString1;
        }

        public  void SetStringTwo(string word)
        {
            _userString2 = word;
            //_userString2 = word.ToLower();
        }

        public string GetStringTwo()
        {
            return _userString2;
        }

        public void SetVarX(int x)
        {
            _x = x;
        }

        public int GetVarX()
        {
            //_x = 0;
            return _x;
        }

     

        //public static List<RepeatCounter> GetAll()
        //{
        //    return _strings;
        //}

        public bool CorrectInput(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            else
            {
                foreach (char letter in input)
                {
                    if (char.IsDigit(letter) || input.Contains(" "))
                    {
                        return false;
                    }
                }
            }
            {
                return true;
            }

        }


        public bool ErrorAlert(string alert)
        {
            return !(CorrectInput(alert));

        }

        public string[] splitWord(string phrase)
        {
            string getString = phrase;
            string[] splitString = getString.Split(' ');
            return splitString;
        }

        public int CheckString(string[] array)
        {
            int x = 0;
            foreach (string word in array)
            {
                if (word == GetStringOne())
                {
                    x++;
                }
            }
            return x;
        }

    }
}