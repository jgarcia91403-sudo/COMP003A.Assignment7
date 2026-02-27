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
            }
        }
    }
}
