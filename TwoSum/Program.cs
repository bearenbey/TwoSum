using System;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given an array of integers nums and an integer target, return
             * indices of the two numbers such that they add up to target. You
             * may assume that each input would have exactly one solution, and
             * you may not use the same element twice.
             */
            
            Console.Write("Please enter the list of numbers with comma separated: ");
            string userInput = Console.ReadLine();
            
            var num = userInput.TrimStart('[').TrimEnd(']').Split(',');
            int[] numList = Array.ConvertAll(num, int.Parse);

            Console.Write("What should be the indice of two numbers? ");
            int userIndice = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numList.Length-1; i++)
            {
                if (numList[i] + numList[i+1] == userIndice)
                {
                    Console.WriteLine($"[{i}, {i+1}]");
                }
            }
        }
    }
}