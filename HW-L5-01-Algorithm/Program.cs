using HW_L5_01_Algorithm.Task1_Fibonacci_series_;
using HW_L5_01_Algorithm.Task2__PrimeNumber_;
using HW_L5_01_Algorithm.Task3_LongestSubArray_;
using HW_L5_01_Algorithm.Task4_TargerNumber_;
using SharedCore;

namespace HW_L5_01_Algorithm
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////task 1 : Fibonacci
            //Fibonacci fibonacci = new Fibonacci();
            //long inputNumber = fibonacci.getInput();
            //long result = fibonacci.calculateFibonacci(inputNumber);
            //fibonacci.printResult(result);
            //Console.WriteLine();

            ////task 2 : Prime Number
            //PrimeNumber primeNumber = new PrimeNumber();
            //long inputNumPrime = primeNumber.getInput();
            //bool resultPrime = primeNumber.isPrime(inputNumPrime);
            //primeNumber.printResult();

            ////task3 : longest subArray
            //LongestIncreasingSubArray longestIncreasingSubArray = new LongestIncreasingSubArray();
            //int[] inputArray = longestIncreasingSubArray.GetInputArray();
            //int maxResult = longestIncreasingSubArray.GetLongestIncreasingSubArray(inputArray);
            //Console.WriteLine($"The max Length is {maxResult}");

            //task4 : findTarget
            int[] arrayNum = GetInputs.GetInputArray();
            long targetNum = GetInputs.getInputNum();
            FindTarget findTarget = new FindTarget();
            findTarget.printResult(findTarget.HasTwoSum(arrayNum, targetNum));
        }
    }
}
