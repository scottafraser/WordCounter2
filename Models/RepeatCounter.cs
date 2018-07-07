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


        public void SetStringOne(string word)
        {
            _userString1 = word;
            _userString1 = word.ToLower();
        }

        public string GetStringOne()
        {
            return _userString1;
        }

        public  void SetStringTwo(string word)
        {
            _userString2 = word;
            _userString2 = word.ToLower();
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
          
            return _x;
        }
  
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

        public bool CorrectInputTwo(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }
            else
            {
                foreach (char letter in input)
                {
                    if (char.IsDigit(letter) || !input.Contains(" "))
                    {
                        return false;
                    }
                }
            }
            {
                return true;
            }

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