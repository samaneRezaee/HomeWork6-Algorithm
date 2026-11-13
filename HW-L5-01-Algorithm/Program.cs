using HW_L5_01_Algorithm.Task1_Fibonacci_series_;
using HW_L5_01_Algorithm.Task2__PrimeNumber_;
using HW_L5_01_Algorithm.Task3_LongestSubArray_;
using HW_L5_01_Algorithm.Task4_TargerNumber_;
using HW_L5_01_Algorithm.Task5;
using HW_L5_01_Algorithm.Task6_uniqe_char_;
using HW_L5_01_Algorithm.Task7_ReverseNumber_;
using HW_L5_01_Algorithm.Task8_isTriangle_;
using SharedCore;

namespace HW_L5_01_Algorithm
{
    public class Program
    {
        static void Main(string[] args)
        {
            //task 1 : Fibonacci
            Fibonacci fibonacci = new Fibonacci();
            long inputNumber = fibonacci.getInput();
            long result = fibonacci.calculateFibonacci(inputNumber);
            fibonacci.printResult(result);
            Console.WriteLine();

            //task 2 : Prime Number
            PrimeNumber primeNumber = new PrimeNumber();
            long inputNumPrime = primeNumber.getInput();
            bool resultPrime = primeNumber.isPrime(inputNumPrime);
            primeNumber.printResult();

            //task3 : longest subArray
            LongestIncreasingSubArray longestIncreasingSubArray = new LongestIncreasingSubArray();
            int[] inputArray = longestIncreasingSubArray.GetInputArray();
            int maxResult = longestIncreasingSubArray.GetLongestIncreasingSubArray(inputArray);
            Console.WriteLine($"The max Length is {maxResult}");

            //task4 : findTarget
            int[] arrayNum = GetInputs.GetInputArray();
            long targetNum = GetInputs.getInputNum();
            FindTarget findTarget = new FindTarget();
            findTarget.printResult(findTarget.HasTwoSum(arrayNum, targetNum));


            //task5 : exchange number to word
            Console.WriteLine("Enter a number between 1 to 9999: ");
            int numberToChange = (int)GetInputs.getInputNum();
            ExchangeNumToChar exchangeNumToChar = new ExchangeNumToChar();
            string word = exchangeNumToChar.NumToChar(numberToChange);
            Console.WriteLine($"{numberToChange} = {word}");

            //task6 : find uniqe char
            UniqueChar uniqueChar = new UniqueChar();
            Console.WriteLine("Please enter an string: ");
            string text = Console.ReadLine();
            Console.Write("The first unique char is: ");
            uniqueChar.FirstUniqueCharacterIndex(text);

            //task7 : reverse number
            ReverseNumber reverseNumber = new ReverseNumber();
            int numberToReverse = GetInputs.getInputNumInt();
            int reverseNum = reverseNumber.Reverse(numberToReverse);
            Console.WriteLine($"Revese of the number is: {reverseNum}");

            //task8 : findTriangle
            FindTriangle findTriangle = new FindTriangle();
            int[] triangleArray = GetInputs.GetInputArray();
            if (findTriangle.CanFormTriangle(triangleArray))
                Console.WriteLine("true");
            else Console.WriteLine("false");

        }
    }
}
