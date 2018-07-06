using System;
using System.Collections.Generic;

namespace WordCount2.Models
{
    public class RepeatCounter
    {
        private  string _userString1;
        private  string _userString2;
        private  int _x;
        private static List<RepeatCounter> _strings = new List<RepeatCounter> { };


        //public RepeatCounter (string word, string words)
        //{
        //    _userString1 = word;
        //    _userString2 = words;

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
            _x = 0;
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
            int x = GetVarX();
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