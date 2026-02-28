using System;
using System.Collections.Generic;
namespace COMP003A.Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> scores = new List<int>() { 85, 90, 78, 92, 88 }; // list of scores to analyze
            int choice = 0;
                Console.WriteLine("\nStudent score Analyzer");
                Console.WriteLine("1. Display all scores");
                Console.WriteLine("2. show total");
                Console.WriteLine("3. show Average");
                Console.WriteLine("4. Exit");
            while (choice != 4) // loop until the user chooses to exit
            {
                Console.WriteLine();
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
foreach (int score in scores) // goes through each score in the list of scores
                        {
                            total += score;
                        }
                        Console.WriteLine("\nTotal:" + total);
                    }
                    else if (choice == 3)
                    {
                        int total = 0;
                        foreach (int score in scores) // calculate the total score
                        {
                            total += score; // adds each score to the total
                        }
                        double average = (double)total / scores.Count; // calculates the average score
                        Console.WriteLine("\nAverage:" + average);
                    }
                    else if (choice == 4)
                    {
                        Console.WriteLine("\nProgram ended.");
                    }
                }
                else
                {
                    if (choice != 0)
                    {
                        Console.WriteLine("Invalid menu option please enter a number between 1 and 4.");
                    }
                }
            }
        }
    }
}
