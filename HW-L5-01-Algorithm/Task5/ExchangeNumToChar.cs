

namespace HW_L5_01_Algorithm.Task5
{
    public class ExchangeNumToChar
    {
        private readonly string[] Units = {
        "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine",
        "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen",
        "Seventeen", "Eighteen", "Nineteen"
    };

        private readonly string[] Tens = {
        "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"
    };
        public string NumToChar(int number)
        {
            if (number == 0)
                return "Zero";

            if (number < 1 || number > 9999)
                return "Out of range (1-9999)";

            string words = "";

            // (Thousands)
            if ((number / 1000) > 0)
            {
                words += Units[number / 1000] + " Thousand ";
                number %= 1000;
            }

            //  (Hundreds)
            if ((number / 100) > 0)
            {
                words += Units[number / 100] + " Hundred ";
                number %= 100;
            }

            //  (Tens & Units)
            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                if (number < 20)
                {
                    words += Units[number];
                }
                else
                {
                    words += Tens[number / 10];
                    if ((number % 10) > 0)
                    {
                        words += " " + Units[number % 10];
                    }
                }
            }

            return words.Trim();
        }


    }

}

