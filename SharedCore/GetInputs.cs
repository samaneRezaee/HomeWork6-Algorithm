namespace SharedCore
{
    public static class GetInputs
    {
        public static int[] GetInputArray()
        {
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
                        .Select(int
                        .Parse)
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

        public static long getInputNum()
        {
            long inputNum;
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
        public static int getInputNumInt()
        {
            int inputNumInt;
            while (true)
            {
                Console.WriteLine("Please enter a number: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out inputNumInt))
                {
                    break;
                }

                Console.WriteLine("Please enter a valid number, it should be an integer! ");
            }
            return inputNumInt;
        }
    }
}
