using System.IO;
using System.Linq;

namespace _01.MostFrequentNumbers
{
    class Program
    {
        static void Main()
        {
            string[] inPut = File.ReadAllLines(@"..\..\inPut.txt");
            string[] result = new string[inPut.Length];

            for (int inPutIndex = 0; inPutIndex < inPut.Length; inPutIndex++)
            {
                int[] currentInPut = inPut[inPutIndex].Split(' ').Select(int.Parse).ToArray();

                int count = 1;
                int maxCount = 0;

                int maxIndex = 0;
                
                for (int index = 0; index < currentInPut.Length - 1; index++)
                {
                    for (int nextIndex = index + 1; nextIndex < currentInPut.Length; nextIndex++)
                    {
                        if (currentInPut[index] == currentInPut[nextIndex])
                        {
                            count++;

                            if (maxCount < count)
                            {
                                maxCount = count;
                                maxIndex = index;
                            }
                        }
                    }

                    count = 1;
                }

                result[inPutIndex] = currentInPut[maxIndex].ToString();
            }

            File.WriteAllLines(@"..\..\outPut.txt", result);
        }
    }
}
