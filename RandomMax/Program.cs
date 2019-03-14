using System;

namespace RandomMax
{
    public static class Program
    {
        public static void Main()
        {
            // TODO: Generate a list of 100 random integers between 0 and 1000 and ouput the maximum value.
            int maxValue = 0;
            int[] numbers = new int[100];
            for (int i = 0; i < 100; i++)
            {
                int randomInt = new Random().Next(0, 1000);
                if (maxValue < randomInt)
                   maxValue = randomInt;      
            }
            Console.WriteLine(maxValue);
            Console.ReadLine();
        }
    }
}
