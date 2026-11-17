using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_L5_01_Algorithm.Task_10_Max_
{
    public class MaxProduct
    {
        public long MaximumProduct(int[] nums)
        {
            Array.Sort(nums);
            int n = nums.Length;

            long p1 = (long)nums[n - 1] * nums[n - 2] * nums[n - 3];
            long p2 = (long)nums[0] * nums[1] * nums[n - 1];

            return Math.Max(p1, p2);
        }

    }
}
