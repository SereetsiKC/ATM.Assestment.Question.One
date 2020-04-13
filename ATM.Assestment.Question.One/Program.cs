using Question.One.MyATM;
using System;

namespace ATM.Assestment.Question.One
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                Console.WriteLine("Please enter your account Number :");
                int accNum = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Please enter your account balance :");
                double bal = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter your Name :");
                string custName = Console.ReadLine();
                Console.WriteLine("Please enter your Surname :");
                string custSname = Console.ReadLine();
                Console.WriteLine("Please enter your Gender :");
                string gend = Console.ReadLine();

                Account account = new Account();
                account.loadAccountData(accNum, bal, custName, custSname, gend);

                Console.WriteLine("Please Eneter the amount to Withdraw :");
                int amount = Convert.ToInt16(Console.ReadLine());
                Withdraw  withdraw = new Withdraw();
                withdraw.withdrawAmount(amount,account);

            }catch(Exception ex)
            {
                Console.WriteLine("values entered are invalid");
            }
            
            Console.ReadKey();
        }
    }
}
