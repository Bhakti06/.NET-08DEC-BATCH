using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5b
{
    class Employee
    {
        public int id;
        public string name;
        public string depart;
        public Employee(int id, string name,string depart)
        {
            this.id = id;
            this.name = name;
            this.depart = depart;


        }
        public override string ToString()
        {
            return ($" Employee Id : {id} \n employeee name: {name} \n department: {depart}");
        }
    }
}
