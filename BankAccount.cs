using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_VirtualOverridingNew
{
    internal class BankAccount
    {
        //fields
        string _name;
        int _accountNumber;
        double _balance;

        public BankAccount(string name, int accountNumber, double balance)
        {
            Name = name;
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public string Name { get => _name; set => _name = value; }
        public int AccountNumber { get => _accountNumber; protected set => _accountNumber = value; }
        public double Balance { get => _balance; protected set => _balance = value; }

        public virtual bool Deposit(double amount)
        {
            if (amount > 0) {
                Balance += amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual bool Withdraw(double amount)
        {
            if (amount > 0 && amount<= Balance)
            {
                Balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} - {Name} - {AccountNumber} - {Balance}";
        }

    }//class

}//namespace
