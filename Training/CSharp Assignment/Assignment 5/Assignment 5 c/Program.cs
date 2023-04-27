using System;
using System.Linq;
using System.Collections.Generic;

namespace Assignment_5_c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of data you want to enter");
            int n = Convert.ToInt32(Console.ReadLine());
            
            List<Employee> employee = new List<Employee>();


            Console.WriteLine("Enter List element: ");
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("EmpId: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("EmpNmae: ");

                string name = Console.ReadLine();

                Console.WriteLine("EmpDepartment: ");

                

                string depart = Console.ReadLine();
                Console.WriteLine("---------------------------------- ");

                employee.Add(new Employee(id, name, depart));

            }

            Console.WriteLine("List is : ");
            foreach (Object x in employee)
            {
                Console.WriteLine(x + "\n");
            }
            Console.WriteLine("---------------------------------- ");
            Console.WriteLine("Total number of data entry in a list " + employee .Count);

            Console.WriteLine("---------------------------------- ");
            Console.WriteLine(" Name you want to find: ");
            string searchName = Console.ReadLine();
            bool isExist = false;

            foreach(Employee e in employee)
            {
                if(e.name.Equals(searchName, StringComparison.InvariantCultureIgnoreCase))
                {
                    isExist = true;
                }
                else
                {
                    isExist = false;
                }
                
            }
            if(isExist == true)
            {
                Console.WriteLine("Name found");
            }
            else
            {
                Console.WriteLine("No record found");
            }
            Console.WriteLine("---------------------------------- ");







        }
    }
}
