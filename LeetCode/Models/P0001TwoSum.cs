using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Models
{
    public class P0001TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            return Go(nums, target);
        }

        private int[] Go(int[] nums, int target)
        {
            var a = 0;
            var b = 0;
            for (var i = 0; i < nums.Length - 1; i++)
            {
                for (var j = i+1; j < nums.Length;j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        a = i;
                        b = j;
                        break;
                    }
                }
            }
            return new []{a,b};
        }
    }
}
