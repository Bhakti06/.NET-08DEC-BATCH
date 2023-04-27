using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpBasic
{
    class Employee
    {
        private int empNo;
        private string empName;
        private double salary;
        private double hra;
        private double ta;
        private double da;
        private double pf;
        private double tds;
        private double netSalary;
        private double grossSalary;

        public Employee(int empNo, string empName, double salary)
        {
            this.empNo= empNo;
            this.empName= empName;
            this.salary = salary;
            
        }

        public void EmpDetails()
        {
            Console.WriteLine("The Emp Id is " + empNo + " The Emp Name is " + empName + "Salary is: " + salary);
        }

        public void Calculate()
        {
            if (this.salary < 5000)
            {
                this.grossSalary = this.salary + (this.salary * 10 / 100) + (this.salary * 5 / 100) + (this.salary * 15 / 100);
                this.pf = this.grossSalary * 10 / 100;
                this.tds = this.grossSalary * 18 / 100;
                this.netSalary = this.grossSalary - (this.pf + this.tds);


            }

            else if (this.salary < 10000)
            {
                this.grossSalary = this.salary + (this.salary * 15 / 100) + (this.salary * 10 / 100) + (this.salary * 20 / 100);
                this.pf = this.grossSalary * 10 / 100;
                this.tds = this.grossSalary * 18 / 100;
                this.netSalary = this.grossSalary - (this.pf + this.tds);
            }
            else if (this.salary < 15000)
            {
                this.grossSalary = this.salary + (this.salary * 20 / 100) + (this.salary * 15 / 100) + (this.salary * 25 / 100);
                this.pf = this.grossSalary * 10 / 100;
                this.tds = this.grossSalary * 18 / 100;
                this.netSalary = this.grossSalary - (this.pf + this.tds);

            }
            else if (this.salary < 20000)
            {
                this.grossSalary = this.salary + (this.salary * 25 / 100) + (this.salary * 20 / 100) + (this.salary * 30 / 100);
                this.pf = this.grossSalary * 10 / 100;
                this.tds = this.grossSalary * 18 / 100;
                this.netSalary = this.grossSalary - (this.pf - this.tds);

            }
            else if (this.salary <= 20000)
            {
                this.grossSalary = this.salary + (this.salary * 30 / 100) + (this.salary * 25 / 100) + (this.salary * 35 / 100);
                this.pf = this.grossSalary * 10 / 100;
                this.tds = this.grossSalary * 18 / 100;
                this.netSalary = this.grossSalary - (this.pf - this.tds);

            }

            Console.WriteLine("GrossSalary is: " + grossSalary + "\n" + "Net Salary is: " + netSalary);
            
            
        }






    }
}
