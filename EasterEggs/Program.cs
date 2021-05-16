using System;

namespace EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < startNumber; i++)
            {
                for (int j = 1; j <= startNumber-i; j++)
                {
                    Console.Write(j);
                }
                for (int j = startNumber - 1 - i; j > 0; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
