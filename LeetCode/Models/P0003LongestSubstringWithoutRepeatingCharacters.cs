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
            var point = 0;
            for (int i = 0; i < s.Length; i++)
            {
                var dictionary = new Dictionary<char, int>();
                for (int x = i; x < point; x++)
                {
                    dictionary.Add(s[x], x);
                }

                for (int j = point; j < s.Length; j++)
                {
                    if (dictionary.ContainsKey(s[j]))
                    {
                        var sub = s.Substring(i, j - i);
                        if (sub.Length > longest.Length)
                        {
                            longest = sub;
                        }
                        i = dictionary[s[j]];
                        point = j;
                        break;
                    }
                    else
                    {
                        dictionary.Add(s[j], j);
                        var sub = s.Substring(i, j - i + 1);
                        if (sub.Length > longest.Length)
                        {
                            longest = sub;
                        }
                        point = j;
                    }
                }
            }
            return longest.Length;
        }
    }
}
