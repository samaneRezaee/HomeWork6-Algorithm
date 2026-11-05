namespace HW_L5_01_Algorithm.Task4_TargerNumber_
{
    public class FindTarget
    {
        long num1, num2, target;
        public bool HasTwoSum(int[] arr, long inputTarger)
        {
            
            if (arr == null || arr.Length < 2)
            {
                return false;
            }

            HashSet<long> seenNum = new HashSet<long>();
            foreach (long num in arr)
            {
                long complement = inputTarger - num;
                if (seenNum.Contains(complement))
                {
                    num1 = num;
                    num2 = complement;
                    target = inputTarger;
                    return true;
                }
                seenNum.Add(num);
            }

            return false;
        }
        
        public void printResult(bool sumResult) 
        {
            if (sumResult)
                Console.WriteLine($"numbers found: {num1} + {num2} = {target}");
            else Console.WriteLine("numbers not found!");
        }
    }
}
