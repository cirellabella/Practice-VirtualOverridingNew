using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_VirtualOverridingNew
{
    internal class SavingsAccount : BankAccount
    {
        //fields
        double _interest;

        public SavingsAccount(string name, int accountNumber, double balance, double interest) : base(name, accountNumber, balance)
        {
            _interest = interest;
        }

        public double Interest { get => _interest; set => _interest = value; }

        public override bool Deposit(double amount)
        {
            if(amount > 0)
            {
                Balance += amount;
                Balance += (amount * _interest);
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Withdraw(double amount)
        {
            {
                if (amount > 0)
                {
                    Balance += amount;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public override string ToString()
        {
            return base.ToString() + $" Interest Amount is: {Interest}";
        }
    }
}
