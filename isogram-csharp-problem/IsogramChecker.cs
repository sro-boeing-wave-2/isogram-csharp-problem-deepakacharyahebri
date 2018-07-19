using System;
using System.Collections.Generic;

namespace isogram_csharp_problem
{
    public class IsogramChecker
    {
        public bool CheckForIsogram(string StringForIsogramCheck)
        {
            Dictionary<char, int> IsogramChecker = new Dictionary<char, int>();
            foreach (char x in StringForIsogramCheck)
            {
                int AsciiValue = (int)x;
                if((AsciiValue >=65 && AsciiValue <=90) || (AsciiValue >=97 && AsciiValue<=122))
                {
                    if (IsogramChecker.ContainsKey(x)) return false;
                    else IsogramChecker.Add(x, 1);
                }
            }
            return true;
        }
    }
}
