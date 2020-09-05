using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace LeetCode.Models
{
    public class P0448FindAllNumbersDisappearedInAnArray
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            if (nums.Length > 0)
            {
                var count = nums.Length;

                var set = new HashSet<int>();
                for (var i = 1; i <= count; i++)
                {
                    set.Add(i);
                }

                foreach (var num in nums)
                {
                    set.Remove(num);
                }

                return set.ToList();
            }
            var list = new List<int>();
            return list;
        }
    }
}
