

namespace HW_L5_01_Algorithm.Task2__PrimeNumber_
{
    public class PrimeNumber
    {
        long inputNum;
        public long getInput()
        {
            while (true)
            {
                Console.WriteLine("Please enter a number: ");
                string input = Console.ReadLine();
                if (long.TryParse(input, out inputNum))
                {
                    break;
                }

                Console.WriteLine("Please enter a valid number, it should be an integer! ");
            }
            return inputNum;
        }
        public bool isPrime(long inputNum)
        {
            if (inputNum <= 1) return false;
            if (inputNum == 2) return true;
            if (inputNum % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(inputNum); i += 2)
            {
                if (inputNum % i == 0) return false;
            }
            return true;
        }

        public void printResult()
        {
            if (isPrime(inputNum))
                Console.WriteLine($"Number: {inputNum} is a 'Prime Number' ");
            else
                Console.WriteLine($"{inputNum} is not a prime number!!!");
            Console.WriteLine();
        }
    }
}
