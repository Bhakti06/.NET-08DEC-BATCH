using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5
{
    class arrayMethod
    {
        int i = 0;
        string[] s = new string[5];
        int[] integer = new int[5];
        string[] s1 = new string[5];
        int[] integer1 = new int[5];

        public arrayMethod()
        {

            Console.WriteLine("  Enter the  String element: ");
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = Console.ReadLine();

            }

            Console.WriteLine("--------------------------------------------------");


            Console.WriteLine("Enter the integer element: ");
            for (int i = 0; i <integer.Length; i++)
            {
                integer[i] = Convert.ToInt32 (Console.ReadLine());

            }

            Console.WriteLine("--------------------------------------------------");

        }

        public void sort()
        {
            Array.Sort(s);
            Console.WriteLine("Sorted array is: ");
            foreach (string value in s)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("\n");

            Array.Sort(integer);
            Console.WriteLine("Sorted array is: ");
            foreach (int value in integer)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("------------------------------------------");
        }
        
        public void reverse()
        {
            Array.Reverse(s);
            Console.WriteLine("Reverse  array is: ");
            foreach (string value in s)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("\n");

            Array.Reverse(integer);
            Console.WriteLine("Reverse array is: ");
            foreach (int value in integer)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("-------------------------------------");
        }

        public void copy()
        {
            Array.Copy(s,s1,s.Length);
            Console.WriteLine("Copy array in new array: ");
            foreach (string value in s)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("\n");

            Array.Copy(integer, integer1, integer.Length);
            Console.WriteLine("Copy array in new array:");
            foreach (int value in integer)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("-------------------------------------");
        }

        public void clear()
        {
            Array.Clear(s, 0, s.Length);
            Console.WriteLine("After clear ");
            foreach (string value in s)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("\n");

            Array.Clear(integer, 0, integer.Length);
            Console.WriteLine("After clear ");
            foreach (int value in integer)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("-------------------------------------");
        }

    }
}