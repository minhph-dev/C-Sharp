using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckAccount
{
    internal class Account
    {
        public string name = "Minh";
        public double balance;

        Validate validate = new Validate();

        public Account(string name, double balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public Account()
        {

        }

        public double Deposit
        {
            get { return balance; }
            set
            {
                if(value < 100)
                {
                    validate.Check("Invalid amount for deposit. Please enter other value !!! (Deposit >= 100)");
                }
                else
                {
                    balance += value;
                }
            }
        }

        public double WithDraw
        {
            get { return balance; }
            set
            {
                if(value < 100 || value > balance)
                {
                    validate.Check("Withdraw cannot > balance and < 100 !!!");
                }
                else
                {
                    balance -= value;
                }
            }
        }

        public void Display()
        {
            Console.WriteLine("\tName: " + name + "\tBalance: " + balance);
        }

    }
}
