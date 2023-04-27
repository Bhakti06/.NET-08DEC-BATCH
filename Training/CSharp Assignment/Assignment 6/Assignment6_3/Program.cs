using System;

namespace Assignment6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            iciciBank icici_customer = new iciciBank(123456, "Bhakti Takane", 5000);
            Console.WriteLine("--------------------------------------------------------------------------------------");

           icici_customer.Deposit(000);
            icici_customer.Withdraw(5000, icici_customer.UnderBalance, icici_customer.ZeroBalance);
            Console.WriteLine("--------------------------------------------------------------------------------------");

           hdfcbank hdfc_customer = new hdfcbank(123456, "Bhakti Takane", 5000);
            hdfc_customer.Deposit(4000);
            hdfc_customer.Withdraw(5000, hdfc_customer.UnderBalance, hdfc_customer.ZeroBalance);

            

        }
    }
}
