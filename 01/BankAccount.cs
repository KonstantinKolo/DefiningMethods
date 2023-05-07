using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class BankAccount
    {
        private int id;
        private double balance;

        public int ID { get; set; }
        public double Balance { get; set; }

        public void Deposit(double ammount)
        {
            Balance += ammount;
        }
        public void Withdraw(double ammount)
        {
            Balance -= ammount;
        }
    }
}
