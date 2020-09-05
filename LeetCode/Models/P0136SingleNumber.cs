using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Models
{
    public class P0136SingleNumber
    {
        public int SingleNumber(int[] nums)
        {
            var set = new HashSet<int>();
            
            foreach (var num in nums)
            {
                if (set.Contains(num))
                {
                    set.Remove(num);
                }
                else
                {
                    set.Add(num);
                }
            }

            return set.FirstOrDefault();
        }
    }
}
