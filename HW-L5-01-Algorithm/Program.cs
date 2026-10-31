using HW_L5_01_Algorithm.Task1_Fibonacci_series_;
using HW_L5_01_Algorithm.Task2__PrimeNumber_;

namespace HW_L5_01_Algorithm
{
    internal class Program
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

        }
    }
}
