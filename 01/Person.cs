﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Person
    {
        private string name;
        private int age;
        List<BankAccount> accounts = new List<BankAccount>();

        public string Name { get; set; }
        public int Age { get; set; }
        public List<BankAccount> Accounts { get; set; }

        public Person(string name, int age) : this(name, age, new List<BankAccount>())
        {
        }
        public Person (string name,int age, List<BankAccount> accounts)
        {
            this.Name = name;
            this.Age = age;
            this.Accounts = accounts;
        }

        public double GetBalance()
        {
            return this.accounts.Sum(el => el.Balance);
        }
    }
}
