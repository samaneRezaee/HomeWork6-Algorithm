

namespace HW_L5_01_Algorithm.Task7_ReverseNumber_
{
    public class ReverseNumber
    {
        public int Reverse(int inputNum)
        {
            long rev = 0;

            while (inputNum != 0)
            {
                int digit = inputNum % 10; 
                inputNum /= 10;
                rev = rev * 10 + digit;
            }

            if (rev > int.MaxValue || rev < int.MinValue)
                return 0;

            return (int)rev;
        }
    }
}
