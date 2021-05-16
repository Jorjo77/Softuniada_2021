using System;
using System.Collections.Generic;
using System.Linq;

namespace EasterBonuses
{
    class Program
    {
        static void Main(string[] args)
        {
            int bonusesSum = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                int[] nums = Console.ReadLine()?
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

                List<int> collectionForCalc = new List<int>();

                int currBonus = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    int currElement = 1;
                    int currNum = nums[i];

                    for (int j = i+1; j < nums.Length; j++)
                    {
                            currElement *= nums[j];
                    }
                    if (i > 0)
                    {
                        for (int k = 0; k <= i - 1; k++)
                        {
                            currElement *= nums[k];
                        }
                    }
                    collectionForCalc.Add(currElement);
                }
                currBonus = collectionForCalc.Sum();
                bonusesSum += currBonus;
                Console.WriteLine($"{input} has a bonus of {currBonus} lv.");

            }
            Console.WriteLine($"The amount of all bonuses is {bonusesSum} lv.");
        }
    }
}