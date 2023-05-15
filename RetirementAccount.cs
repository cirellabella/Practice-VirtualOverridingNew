using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_VirtualOverridingNew
{
    internal class RetirementAccount : SavingsAccount
    {
        public RetirementAccount(string name, int accountNumber, double balance, double interest) : base(name, accountNumber, balance, interest)
        {
        }

        //method
        public override bool Withdraw(double amount)
        {
            Console.WriteLine("Cannot withdraw from a retirement account");
            return false;
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

    }
}
