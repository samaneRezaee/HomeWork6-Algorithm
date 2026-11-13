

namespace HW_L5_01_Algorithm.Task8_isTriangle_
{
    public class FindTriangle
    {
        public bool CanFormTriangle(int[] nums)
        {
            if (nums.Length < 3)
                return false;

            Array.Sort(nums);

            for (int i = 0; i < nums.Length - 2; i++)
            {
                
                if ((long)nums[i] + nums[i + 1] > nums[i + 2])
                    return true;
            }

            return false;
        }
    }
}
