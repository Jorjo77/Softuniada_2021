using System;
using System.Collections.Generic;

namespace EisterPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            List<int> primeNumbers = new List<int>();
            int count = 0;
            for (int i = startNumber; i <= endNumber; i++)
            {
                if (IsPrime(i))
                {
                    primeNumbers.Add(i);
                    count++;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(string.Join(" ", primeNumbers));
            Console.WriteLine($"The total number of prime numbers between {startNumber} to {endNumber} is {count}");
        }
        public static bool IsPrime(int i)
        {
            if (i <= 1) return false;
            if (i == 2) return true;
            if (i % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(i));

            for (int j = 3; j <= boundary; j += 2)
                if (i % j == 0)
                    return false;

            return true;
        }
    }
}
