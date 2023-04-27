using System;
using System.Data.SqlClient;
namespace AdoNetConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Connecting();
        }
        public void Connecting()
        {
           
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                
                con = new SqlConnection(@"data source=LIN80024365\SQLEXPRESS; database=Sample; integrated security=SSPI");
                con.Open();

                // Table creation 
                //SqlCommand query1 = new SqlCommand("create table Connection(id int primary key not null,name nvarchar(100), email nvarchar(50))", con);
                //query1.ExecuteNonQuery();
                //Console.WriteLine("Table Created");
                int ch = 0;
                do
                {
                    Console.WriteLine("Select your choice\n 1.Select\n2.Insert\n3.Delete\n4.Update\n5.Search\n6.Exit");
                    ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            //retrive data
                            SqlCommand query3 = new SqlCommand("Select * from Connection", con);

                            Console.WriteLine("Retrived Data is");
                            SqlDataReader sq = query3.ExecuteReader();

                            while (sq.Read())
                            {
                                Console.WriteLine(sq["id"] + " " + sq["name"] + " " + sq["email"]);
                            }
                            sq.Close();
                            break;
                        case 2:
                            // inserting data
                            Console.WriteLine("Enter Id:");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Name:");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter Email:");
                            string email = Console.ReadLine();


                            SqlCommand query2 = new SqlCommand($"insert into Connection values({id},'{name}', '{email}')", con);
                            query2.ExecuteNonQuery();
                            Console.WriteLine("Data inserted successfully");

                            SqlCommand query_ = new SqlCommand("Select * from Connection", con);

                            Console.WriteLine("Retrived Data is");
                            SqlDataReader sq1 = query_.ExecuteReader();

                            while (sq1.Read())
                            {
                                Console.WriteLine(sq1["id"] + " " + sq1["name"] + " " + sq1["email"]);
                            }
                            sq1.Close();
                            break;

                        case 3:
                            //deleting record
                            Console.WriteLine("Enter the id you want to delete..");
                            int id1 = Convert.ToInt32(Console.ReadLine());
                            SqlCommand query4 = new SqlCommand($"delete from Connection where id = {id1}", con);

                            query4.ExecuteNonQuery();
                            Console.WriteLine("Data Deleted successfully..");

                            SqlCommand query_d = new SqlCommand("Select * from Connection", con);

                            Console.WriteLine("Retrived Data is");
                            SqlDataReader sq_d = query_d.ExecuteReader();

                            while (sq_d.Read())
                            {
                                Console.WriteLine(sq_d["id"] + " " + sq_d["name"] + " " + sq_d["email"]);
                            }
                            sq_d.Close();
                            break;


                        case 4:
                            Console.WriteLine("Enter the id you want to update..");
                            int id2 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Name:");
                            string name2 = Console.ReadLine();
                            Console.WriteLine("Enter Email:");
                            string email2 = Console.ReadLine();

                            SqlCommand query5 = new SqlCommand($"update  Connection set name='{name2}',email='{email2}' where id = {id2}", con);
                            query5.ExecuteNonQuery();

                            SqlCommand query7= new SqlCommand("Select * from Connection", con);

                            Console.WriteLine("Retrived Data is");
                            SqlDataReader sq2 = query7.ExecuteReader();

                            while (sq2.Read())
                            {
                                Console.WriteLine(sq2["id"] + " " + sq2["name"] + " " + sq2["email"]);
                            }
                            sq2.Close();
                            break;


                        case 5:
                            Console.WriteLine("Enter the id you want to search");
                            int id3 = Convert.ToInt32(Console.ReadLine());
                            SqlCommand query6 = new SqlCommand($"select * from Connection where id = {id3}", con);
                            query6.ExecuteNonQuery();
                            break;

                        case 6:
                            break;
                        default:
                            Console.WriteLine("Choose correct option....");
                            break;
                    }
                } while (ch!=6);
                
                
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }
            finally
            {   // Closing the connection  
                con.Close();
            }
        }
    }
}