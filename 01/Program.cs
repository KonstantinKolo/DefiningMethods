using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();
            while (true)
            {               
                string command = Console.ReadLine();

                var commandArgs = command.Split();
                var commandType = commandArgs[0];

                if (commandType == "End")
                {
                    break;
                }
                switch (commandType)
                {
                    case "Create":
                        Create(commandArgs, accounts);
                        break;
                    case "Deposit":
                        Deposit(commandArgs, accounts);
                        break;
                    case "Withdraw":
                        Withdraw(commandArgs, accounts);
                        break;
                    case "Print":
                        Print(commandArgs, accounts);
                        break;
                }
                
            }
        }

        private static void Create(string[] cmd,Dictionary<int,BankAccount> accounts)
        {
            var id = int.Parse(cmd[1]);
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists!");
            }
            else
            {
                var acc = new BankAccount();
                acc.ID = id;
                accounts.Add(id, acc);
            }
        }
        private static void Deposit(string[] cmd, Dictionary<int, BankAccount> accounts)
        {
            int id = int.Parse(cmd[1]);
            double ammount = double.Parse(cmd[2]);
            if(accounts.ContainsKey(id) == false)
            {
                Console.WriteLine("Account does not exist!");
            }
            else
            {
                accounts[id].Deposit(ammount);
            }
        }
        private static void Withdraw(string[] cmd, Dictionary<int, BankAccount> accounts)
        {
            int id = int.Parse(cmd[1]);
            double ammount = double.Parse(cmd[2]);
            if (accounts.ContainsKey(id) == false)
            {
                Console.WriteLine("Account does not exist!");
            }
            else
            {
                if (accounts[id].Balance < ammount)
                {
                    Console.WriteLine("Insuffition balance!");
                }
                else
                {
                    accounts[id].Withdraw(ammount);
                }
            }
        }
        private static void Print(string[] cmd, Dictionary<int, BankAccount> accounts)
        {
            int id = int.Parse(cmd[1]);
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist!");
            }
            else
            {
                Console.WriteLine($"Account ID{id}, balance {accounts[id].Balance:F2}");
            }
        }
    }
}
