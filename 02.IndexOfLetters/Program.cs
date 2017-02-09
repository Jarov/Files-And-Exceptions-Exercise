using System.IO;
using System.Collections.Generic;

namespace _02.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inPut = File.ReadAllLines(@"..\..\inPut.txt");
            Dictionary<char, int> charIndex= new Dictionary<char, int>();

            for (int inPutIndex = 0; inPutIndex < inPut.Length; inPutIndex++)
            {
                char[] currentInPut = inPut[inPutIndex].ToCharArray();

                for (int index = 0; index < currentInPut.Length; index++)
                {
                    charIndex[currentInPut[index]] = currentInPut[index] - 'a';
                }
            }

            string[] result = new string[charIndex.Count];
            
            int resultIndex = 0;

            foreach (KeyValuePair<char, int> letter in charIndex)
            {
                result[resultIndex] = $"{letter.Key} -> {letter.Value}";
                resultIndex++;
            }

            File.WriteAllLines(@"..\..\outPut.txt", result);
        }
    }
}
