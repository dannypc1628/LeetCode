using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Models
{
    public class P0268MissingNumber
    {
        public int MissingNumber(int[] nums)
        {
            Array.Sort(nums);
            var i = 0;
            foreach (var num in nums)
            {
                if (i != num)
                    return i;
                i++;
            }
            return i;
        }
    }
}
