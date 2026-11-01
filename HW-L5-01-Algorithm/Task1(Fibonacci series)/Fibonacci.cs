
namespace HW_L5_01_Algorithm.Task1_Fibonacci_series_
{
    public class Fibonacci
    {
        long inputNum;
        long result;

        public long getInput()
        {
            while (true)
            {
                Console.WriteLine("Please enter a number: ");
                string input= Console.ReadLine();
                if (long.TryParse(input, out inputNum)) 
                {
                    break;
                }

                Console.WriteLine("Please enter a valid number, it should be an integer! ");
            }
            return inputNum;
        }

        public long calculateFibonacci(long inputNum) 
        {
            long num1 =0;
            long num2 =1;
            long temp;
            if (inputNum == 0) return 0;
            if (inputNum == 1) return 1;
            for (int i = 2; i < inputNum; i++)
            {
                temp = num1 + num2;
                num1 = num2;
                num2 = temp;
            }
            result = num2;
            return result;
        }
        public void printResult(long num) 
        {
            Console.WriteLine($"The result is: {result}");
        }


    }
}
