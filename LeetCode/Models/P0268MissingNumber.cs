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

        public int MissingNumber2(int[] nums)
        {
            var max = nums.Max();
            int total;
            if (max < nums.Length)
                total = (max+1 + 0) * (max+1 + 1) / 2;
            else
                total = (max + 0) * (max + 1) / 2;
            foreach (var num in nums)
            {
                total -= num;
            }

            return total;
        }
    }
}
