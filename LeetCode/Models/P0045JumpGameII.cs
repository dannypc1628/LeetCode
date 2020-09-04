using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Models
{
    public class P0045JumpGameII
    {
        public int Jump(int[] nums)
        {
            if (nums.Length == 1)
                return 0;
            return Go(nums, 0, 0);
        }

        private int Go(int[] nums, int point, int count)
        {
            var maxLength = nums[point];
            if (point + maxLength >= nums.Length - 1)
                return count + 1;

            var nextPoint = 0;
            for (int i = 1; i <= maxLength; i++)
            {
                var nowPoint = point + i;
                if (nums[nowPoint] + nowPoint >= nums[nextPoint] + nextPoint)
                {
                    nextPoint = nowPoint;
                }
            }

            return Go(nums, nextPoint, count + 1);
        }
    }
}
