using System;

namespace CsharpBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 

            Console.WriteLine("Employee no : ");
            int empId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Employee Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Employee Salary : ");
            int sal = Convert.ToInt32(Console.ReadLine());
        
            
                if (empId < 0 || empId == 0 || sal < 0 || sal == null || name == null)
                {
                    Console.WriteLine("Error: Please check your details... empId,name and salary not be zero or null");

                }

                
                else
                {
                    Employee emp = new Employee(empId, name, sal);

                    emp.EmpDetails();
                    emp.Calculate();
                }
                
            }catch(Exception emp)
            {
                Console.WriteLine(emp);
            }
  


        }
    }
}
