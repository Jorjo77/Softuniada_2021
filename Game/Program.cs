using System;
using System.Collections.Generic;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();

            string manFirstWord = firstWord;
            int count = 0;
            string resultWord = string.Empty;
            for (int i = 0; i < manFirstWord.Length; i++)
            {
                string currSimbol = manFirstWord[manFirstWord.Length - 1 - i].ToString() ;
                int index = manFirstWord.Length - 1 - i;
                resultWord = manFirstWord.Remove(index, 1);
                resultWord.Insert(0, currSimbol);

                count++;
                if (resultWord.CompareTo(secondWord) == 0)
                {
                    Console.WriteLine($"The minimum operations required to convert { firstWord } to {secondWord} are {count}");
                }
            }

            if (resultWord.CompareTo(secondWord) == 0)
            {
                Console.WriteLine("The name cannot be transformed!");
            }

        }
    }
}
