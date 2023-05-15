using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_VirtualOverridingNew
{
    internal class CheckingAccount : BankAccount
    {
        //fields
        double _overdraftFee;


        public CheckingAccount(string name, int accountNumber, double balance, double overdraftFee) : base(name, accountNumber, balance)
        {
            _overdraftFee = overdraftFee;
        }

        public double OverdraftFee { get => _overdraftFee; set => _overdraftFee = value; }

        //Method override Withdraw
        public override bool Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                return true;
            }
            else
            {
                Balance -= _overdraftFee;
                return false;
            }
        }

        public override bool Deposit(double amount)
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
            return base.ToString() + $" Overdraft Fee is: {OverdraftFee:c0}";
        }
    }
}
