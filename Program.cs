namespace Practice_VirtualOverridingNew
{
    internal class Program
    {
        static List<BankAccount> accounts = new List<BankAccount>();
        static void Main(string[] args)
        {
            Random rand = new Random();

            SavingsAccount sa = new SavingsAccount("Kasey", rand.Next(), 10000, 0.045);
            CheckingAccount ca = new CheckingAccount("Cirella", rand.Next(), 2000, 40);
            RetirementAccount ra = new RetirementAccount("Kim", rand.Next(), 500000, 0.075);

            accounts.Add(sa);
            accounts.Add(ca);
            accounts.Add(ra);


            //Deposit 500 each account
            Console.WriteLine("Attempt to deposit 500:");
            foreach (BankAccount a in accounts)
            {
                Console.WriteLine(a.Deposit(500));
            }
            foreach (BankAccount a in accounts)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("\n");

            //deposit -50000
            Console.WriteLine("Attempt to deposit -50000:");
            foreach (BankAccount a in accounts)
            {
                Console.WriteLine(a.Deposit(-50000));
            }
            foreach (BankAccount a in accounts)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("\n");

            //withdraw 200
            Console.WriteLine("Attempt to withdraw 200:");
            foreach (BankAccount a in accounts)
            {
                Console.WriteLine(a.Withdraw(200));
            }
            foreach (BankAccount a in accounts)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("\n");

            //withdraw -200000
            Console.WriteLine("Attempt to withdraw -200000:");
            foreach (BankAccount a in accounts)
            {
                Console.WriteLine(a.Withdraw(-200000));
            }
            foreach (BankAccount a in accounts)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("\n");
        }
    }
}