using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Models
{
    public class P0217ContainsDuplicate
    {
        public bool ContainsDuplicate(int[] nums)
        {
            var set = new HashSet<int>();
            foreach (var num in nums)
            {
                if (set.Contains(num))
                    return true;
                else
                {
                    set.Add(num);
                }
            }

            return false;
        }
    }
}
