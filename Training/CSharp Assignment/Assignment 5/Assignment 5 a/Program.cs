using System;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {

            int choice = 0;
            arrayMethod arr = new arrayMethod();


            Console.WriteLine("\n----------------------------------------------\n");
            while (choice != 5)
            {
                Console.WriteLine("Chose one from the below options...\n");
                Console.WriteLine("\n1.Sort\n2.Reverse\n3.Copy\n4.Clear\n5.Exit");
                Console.WriteLine("\n Enter your choice \n");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            arr.sort();
                            break;
                        }
                    case 2:
                        {
                            arr.reverse();
                            break;
                        }
                    case 3:
                        {
                            arr.copy();
                            break;
                        }
                    case 4:
                        {
                            arr.clear();
                            break;
                        }

                    case 5:
                        {
                            Console.WriteLine("Exiting....");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please Enter valid choice ");
                            break;
                        }
                };


            }
        }
    }
}
