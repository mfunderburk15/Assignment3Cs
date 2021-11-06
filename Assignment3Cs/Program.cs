using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> likes = new List<string>();
            while(true)
            {
                Console.Write("Please enter a name: ");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                else
                {
                    likes.Add(input);
                    continue;
                }
            }
            if (likes.Count == 1)
            {
                Console.WriteLine($"{likes[0]} like your post.");
            }
            else if (likes.Count == 2)
            {
                Console.WriteLine($"{likes[0]} and {likes[1]} like your post.");
            }
            else if (likes.Count > 2)
            {
                Console.WriteLine($"{likes[0]}, {likes[1]}, and {likes.Count - 2} others like your post.");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
