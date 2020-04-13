using System;
using System.Collections.Generic;
using System.Text;

namespace Question.One.MyATM
{
    public class Deposit
    {
        public void DepMoney(int amount, Account account)
        {
            account.balance += amount;
        }
    }
}
