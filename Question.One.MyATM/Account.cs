using System;
using System.Collections.Generic;
using System.Text;

namespace Question.One.MyATM
{
    public class Account
    {
        public int accountNumber;
        public double balance;
        public string customerName;
        public string customerSurname;
        public string gender;

        public void loadAccountData(int accNum,double bal,string custName,string custSname,string gend)
        {
            this.accountNumber = accNum;
            this.balance = bal;
            this.customerName = custName;
            this.customerSurname = custSname;
            this.gender = gend;
        }
    }
}
