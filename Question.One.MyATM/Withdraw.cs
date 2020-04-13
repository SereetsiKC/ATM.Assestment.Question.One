using System;
using System.Collections.Generic;
using System.Text;

namespace Question.One.MyATM
{
    public class Withdraw
    {
        public void withdrawAmount(int amount, Account account)
        {
            Balance bal = new Balance();
            double balance = bal.checkBal(account);

            if (balance >= amount)
            {
                account.balance = balance - amount;

                Console.WriteLine("Acount Holder\t: " + account.customerName + " " + account.customerSurname);
                Console.WriteLine("Amount withdrawn\t: R" + amount.ToString("N2"));
                Console.WriteLine("Available Balance\t: R"+account.balance.ToString("N2"));
                Console.WriteLine("Date Of Transaction\t: " + DateTime.Now.ToString("yyyy-MM-dd"));
            }
            else
            {
                Console.WriteLine("insufficient funds");
                Console.WriteLine("Acount Holder\t: " + account.customerName + " " + account.customerSurname);
                Console.WriteLine("Amount requested\t: R" + amount.ToString("N2"));
                Console.WriteLine("Available Balance\t: R" + account.balance.ToString("N2"));
                Console.WriteLine("Date Of Transaction\t: " + DateTime.Now.ToString());
            }
        }
    }
}
