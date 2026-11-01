

namespace HW_L5_01_Algorithm.Task3_LongestSubArray_
{
    public class LongestIncreasingSubArray
    {
        public int[] GetInputArray()
        {
            Console.WriteLine("--- find longest increasing subArray length ---");
            Console.WriteLine("Please enter your array: (split numbers by space.)");

            string inputArray;
            int[] numbers = Array.Empty<int>();

            while (true)
            {
                inputArray = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(inputArray))
                {
                    Console.WriteLine("error: input can not be empty! try again");
                    continue;
                }

                try
                {
                    numbers = inputArray.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();
                    if (numbers.Length == 0)
                    {
                        Console.WriteLine("Error: no valid numbers found. Try again.");
                        continue;
                    }

                    break;

                }
                catch (FormatException)
                {
                    Console.WriteLine("Just enter integer numbers!");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Number is too large / too small for int. Try again.");
                    continue;
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    continue;
                }
            }//end of while

            return numbers;
        }//end of input method

        public int GetLongestIncreasingSubArray(int[] arr)
        {
            if (arr == null || arr.Length == 0) { return 0; }
            int maxLength = 1;
            int currentLength = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    currentLength++;
                }
                else
                {
                    maxLength = Math.Max(maxLength, currentLength);
                    currentLength = 1;
                }
            }
            maxLength = Math.Max(maxLength, currentLength);
            return maxLength;
        }//end of maxLength method
    }
}
