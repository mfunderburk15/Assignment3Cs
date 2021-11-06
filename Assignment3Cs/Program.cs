using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

            If no one likes your post, it doesn't display anything.
            If only one person likes your post, it displays: [Friend's Name] likes your post.
            If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
            If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.

            Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name).
            Depending on the number of names provided, display a message based on the above pattern
             */


            //List<string> likes = new List<string>();
            //while(true)
            //{
            //    Console.Write("Please enter a name: ");
            //    string input = Console.ReadLine();
            //    if (string.IsNullOrWhiteSpace(input))
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        likes.Add(input);
            //        continue;
            //    }
            //}
            //if (likes.Count == 1)
            //{
            //    Console.WriteLine($"{likes[0]} like your post.");
            //}
            //else if (likes.Count == 2)
            //{
            //    Console.WriteLine($"{likes[0]} and {likes[1]} like your post.");
            //}
            //else if (likes.Count > 2)
            //{
            //    Console.WriteLine($"{likes[0]}, {likes[1]}, and {likes.Count - 2} others like your post.");
            //}
            //else
            //{
            //    Console.WriteLine();
            //}

            /*
               Write a program and ask the user to enter their name.
               Use an array to reverse the name and then store the result in a new string.
               Display the reversed name on the console.
             */

            //Console.Write("Please enter your name: ");
            //string name = Console.ReadLine();

            //char[] arr = new char[name.Length];
            //for (int i = name.Length; i>0; i--)
            //{
            //    arr[name.Length - i] = name[i - 1];
            //}
            //string reversed = new string(arr);
            //Console.WriteLine(reversed);

            /*
                Write a program and ask the user to enter 5 numbers.
            If a number has been previously entered, display an error message and ask the user to re-try.
            Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
             */

            //List<int> numbers = new List<int>();

            //while (numbers.Count < 5)
            //{
            //    Console.Write("Please enter a number: ");
            //    int input = Convert.ToInt32(Console.ReadLine());
            //    if (numbers.Contains(input))
            //    {
            //        Console.WriteLine("Number already entered: " + input);
            //        continue;
            //    }
            //    numbers.Add(input);
            //}

            //numbers.Sort();
            //foreach (int i in numbers)
            //{ 
            //    Console.WriteLine(i); 
            //}

            /*
               Write a program and ask the user to continuously enter a number or type "Quit" to exit.
               The list of numbers may include duplicates.
               Display the unique numbers that the user has entered.
             */

            //List<int> numbers = new List<int>();
            //List<int> unique = new List<int>();

            //while(true)
            //{
            //    Console.Write("Please enter a number or type \"Quit\" to display unique numbers : ");
            //    string input = Console.ReadLine().ToLower();
            //    if(input == "quit")
            //    {
            //        break;
            //    }
            //    int number = Convert.ToInt32(input);
            //    numbers.Add(number);
            //}

            //foreach(int i in numbers)
            //{
            //    if (!unique.Contains(i))
            //    {
            //        unique.Add(i);
            //    }
            //}
            //Console.WriteLine("Unique numbers: ");
            //foreach(int i in unique)
            //{
            //    Console.Write(i);
            //}

            /*
               Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
               If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list. 
             */

            List<int> numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Insert at least 5 numbers separated by commas: ");
                string input = Console.ReadLine();

                string[] ToSplit = input.Split(",");
                if (ToSplit.Length < 5 )
                {
                    Console.WriteLine("Invalid List, please try again");
                    continue;
                }
                else
                {
                    foreach (String n in ToSplit)
                    {
                        numbers.Add(Convert.ToInt32(n));
                    }

                    numbers.Sort();
                  
                    Console.Write($"{numbers[0]}, {numbers[1]}, {numbers[2]}");
                    break;
                }
            }

        }
    }
}
