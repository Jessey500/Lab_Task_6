using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_6
{
    class Account
    {
        private string accName;

        public string AccName 
        {
            get { return accName; }
            set { accName = value; }
        }
        private string accNo;

        public string AccNo
        {
            get { return accNo; }
            set { accNo = value; }
        }
        private int balance;

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public Account() { }

        public Account(string accName, string accNo, int balance)
        {
            this.accName = accName;
            this.accNo = accNo;
            this.balance = balance;
        }
         public void Deposit(int amount)
        {
            balance+=amount;
         }
 
        public void Withdraw(int amount)
        { if(amount<balance)
        { balance-=amount;}
        else
            Console.WriteLine("Insufficient balance")
        }
        public void Transfer(int amount)
        {
            if (balance>amount)
            { balance -= amount;}
                Console.WriteLine("Balance after transfer")
            else 
                Console.WriteLine("Amount extends balance ")
        }
            {
                public void Receive(int amount)
                { balance+=amount;
                }
        public void ShowInfo()
        {
           Console.WriteLine("AccName: "+ accName)
           Console.WriteLine("AccNo: "+ accNo)
           Console.WriteLine("Balance: "+ balance)
           
        }
   
   
}
