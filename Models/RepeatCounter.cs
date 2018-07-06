using System;
namespace WordCount2.Models
{
    public class RepeatCounter
    {
        private string _userString1;
        private string _userString2;
        private int _x;

        public void SetStringOne(string word)
        {
            _userString1 = toLowerCase(word);
        }

        public string GetStringOne()
        {
            return _userString1;
        }

        public void SetStringTwo(string word)
        {
            _userString2 = toLowerCase(word);
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

        public string toLowerCase(string input)
        {
            string lowerString = input.ToLower();
            return lowerString;
        }

        public bool CorrectInput(string input)
        {
            bool test = true;
            if (IsNull(input) == true)
            {
                test = false;
            }
            else
            {
                foreach (char letter in input)
                {
                    if (char.IsDigit(letter) || input.Contains(" "))
                    {
                        test = false;
                    }
                    else
                    {
                        test = true;
                    }
                }
            }

            return test;
        }

        public bool IsNull(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ErrorAlert(string alert)
        {
            if (CorrectInput(alert) == false)
            {
                return true;
            }
            else
            {
                return false;
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