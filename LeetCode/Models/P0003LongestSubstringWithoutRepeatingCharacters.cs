using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Models
{
    public class P0003LongestSubstringWithoutRepeatingCharacters
    {
        public int LengthOfLongestSubstring(string s)
        {
            var longest = "";
            for (int i = 0; i < s.Length; i++)
            {
                var dictionary = new Dictionary<char, int>();
                for (int j = i; j < s.Length; j++)
                {
                    if (dictionary.ContainsKey(s[j]))
                    {
                        var sub = s.Substring(i, j - i);
                        if (sub.Length > longest.Length)
                        {
                            longest = sub;
                        }
                        break;
                    }
                    else
                    {
                        dictionary.Add(s[j], 1);
                        var sub = s.Substring(i, j - i+1);
                        if (sub.Length > longest.Length)
                        {
                            longest = sub;
                        }
                    }
                }
            }
            return longest.Length;
        }
    }
}
