
using System;
using System.Reflection;


namespace Assignment_8_a
{
    public class Reflection
    {
        public string fullName(string firstName, string lastName)
        {
            string fullname = firstName +" " + lastName;
            return fullname;
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            Type reflectionType =executingAssembly.GetType("Assignment_8_a.Reflection");
            object fname = Activator.CreateInstance(reflectionType);
            MethodInfo addString = reflectionType.GetMethod("fullName");
            Console.WriteLine($"Type: {reflectionType}");
            MethodInfo[] methods = reflectionType.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType.Name + "  " + method.Name);
            }


            string[] parameter = new string[2];
            parameter[0] = "Bhakti";
            parameter[1] = "Takane";


            string res = (string)addString.Invoke(fname, parameter);
            Console.WriteLine($"Full Name is = {res}");

          
            
            

            


        }
    }
}
