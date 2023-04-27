using System;
using System.Collections;

namespace Assignment_5b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of data you want to enter");
            int n = Convert.ToInt32(Console.ReadLine());

            ArrayList employee = new ArrayList();


            Console.WriteLine("Enter details: ");
            for(int i = 0; i<=n; i++)
            {
                Console.WriteLine("EmpId: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("EmpNmae: ");

                string name = Console.ReadLine();

                Console.WriteLine("EmpDepartment: ");

                string depart = Console.ReadLine();

                employee.Add(new Employee(id, name, depart));
                        
            }

            Console.WriteLine("Details are : ");
            foreach(Object x in employee)
            {
                Console.WriteLine(x + "\n");
            }


            
        }
    }
}
