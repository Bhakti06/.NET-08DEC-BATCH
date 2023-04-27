using System;
using System.Data.Entity;

namespace CodeFirstDemo
{
    public class Person2
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
    public class personContext : DbContext
    {
        public DbSet<Person2> Person1s { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var context = new personContext();
            int i;
            int Id;
            string Name;
            string Email;

            do
            {
                Console.WriteLine("Choose option:\n1.Insert\n2.Retrive\n3.Delete\n4.Update\n.5.Exit");

               i = Convert.ToInt32(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        {
                            Console.WriteLine("ID: ");
                            Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Name: ");
                            Name = Console.ReadLine();
                            Console.WriteLine("Email:");
                            Email = Console.ReadLine();

                            var person = new Person2

                            {
                                Id = 1,
                                Name = "Rajdeep",
                                Email = "raj@gmail.com"
                            };
                            context.Person1s.Add(person);
                            context.SaveChanges();
                            Console.WriteLine("Insert Successfully");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter the id you want to delete");
                            Id = Convert.ToInt32(Console.ReadLine());
                            var person = new Person2

                            {
                                Id = Id
                            };

                            context.Person1s.Attach(person);
                            context.Person1s.Remove(person);
                            context.SaveChanges();
                            Console.WriteLine("data removed");
                            break;
                        }
                    case 3:
                        {
                            using (var x = new personContext())
                            {
                                foreach (var p in x.Person1s)
                                {
                                    Console.WriteLine(p.Id + " " + p.Name + " " + p.Email);
                                }
                            }
                            Console.WriteLine("data retrieved");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("enter the id you want to update");
                            Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("enter the new name");
                            Name = Console.ReadLine();
                            var person = new Person2
                            {
                                Id = Id,
                                Name = Name,
                            };
                            context.Person1s.Attach(person);
                            context.Entry(person).Property(p => p.Name).IsModified = true;
                            context.SaveChanges();
                            break;
                        }
                    case 5:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("invalid input");
                            break;
                        }
                }



            } while (i != 5);
            Console.ReadKey();
        }


        /*    var person = new Person2

            {
                Id = 1,
                Name = "Rajdeep",
                Email = "raj@gmail.com"
            };
            context.Person1s.Add(person);
            context.SaveChanges();*/




        //update data
        //context.Person1s.Attach(person);
        //context.Entry(person).Property(p => p.Name).IsModified = true;
        //  context.SaveChanges();

        //retrive data
        /*using (context)
        {
            foreach (var p in context.Person1s)
            {
                Console.WriteLine(p.Id+" "+ p.Name + " " + p.Email);
            }
        }*/

        //delete
        /*    var p1 = new Person2 { Id = 1, };
            context.Person1s.Attach(p1);
            context.Person1s.Remove(p1);
            context.SaveChanges();*/

        //Console.ReadKey();
    }
}
  
