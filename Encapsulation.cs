using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSdemo058
{
    class Account
    {

        int accountBalance = 1000;
        public void SetBalance(int amount)
        {
            accountBalance = amount;
        }
        public void GetBalance()
        {
            Console.WriteLine("Your Account Balance is" + accountBalance);

        }
    }

    class Program
    {
        static void Main(String[] args)
        {
            Account myAccount = new Account();
            myAccount.SetBalance(10000);
            myAccount.GetBalance();
            Console.ReadLine();
        }
    }

}