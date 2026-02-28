using System;
using System.Collections.Generic;
namespace COMP003A.Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> scores = new List<int>() { 85, 90, 78, 92, 88 };
            int choice = 0;
            while (choice != 4)
            {
                Console.WriteLine("\nStudent score Analyzer");
                Console.WriteLine("1. Display all scores");
                Console.WriteLine("2. show total");
                Console.WriteLine("3. show Average");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice:");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. pleaes enter a number between 1 and 4.");
                    choice = 0;
                }
                if (choice >= 1 && choice <= 4)
                {
                    if (choice == 1)
                    {
                        Console.WriteLine("\nScores:");
                        foreach (int score in scores)
                        {
                            Console.WriteLine(score);
                        }
                    }
                    else if (choice == 2)
                    {
                        int total = 0;
foreach (int score in scores)
                        {
                            total += score;
                        }

                    }
                }
            }
        }
    }
}
