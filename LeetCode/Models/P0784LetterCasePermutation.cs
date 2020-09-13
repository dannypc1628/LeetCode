using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Models
{
    public class P0784LetterCasePermutation
    {
        public IList<string> LetterCasePermutation(string s)
        {
            return GetCase(s);
        }

        private IList<string> GetCase(string s)
        {
            var point = 0;
            foreach (var c in s)
            {
                if (char.IsLetter(c))
                {
                    break;
                }
                point++;
            }
            if (point == s.Length)
                return new List<string>() { s };

            var sEndList = GetCase(s.Substring(point+1));
            var sub = s.Substring(0, point);
            var list = new List<string>();

            foreach (var strItem in sEndList)
            {
                list.Add(sub + char.ToUpper(s[point]) + strItem);
                list.Add(sub + char.ToLower(s[point]) + strItem);
            }

            return list;
        }
    }
}
