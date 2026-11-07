

namespace HW_L5_01_Algorithm.Task6_uniqe_char_
{
    public class UniqueChar
    {
        public int FirstUniqueCharacterIndex(string text)
        {
            var counts = new Dictionary<char, int>();

            
            foreach (char c in text)
            {
                counts[c] = counts.GetValueOrDefault(c, 0) + 1;
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (counts[text[i]] == 1)
                {
                    Console.WriteLine(text[i]);
                    return 1;
                }
            } 
            
            return -1;
        }
    }
}
