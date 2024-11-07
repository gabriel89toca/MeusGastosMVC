using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeusGastosMVC.Models
{
    public class Account
    {
        //      Account
        //- balance: decimal
        //- openingDate: date
        //+ deposit(amount: decimal) : void
        //+ withdraw(amount: decimal) : void
        //+ generateStatement() : List<Transaction>
        public int Id { get; set; }
        protected double Balance = 0.0;
        public string Description { get; set; }
        public DateTime OpeningDate { get; set; }

        private void Deposit(double amount)
        {
            Balance = Balance + amount;
        }

        private void Withdraw(double amount)
        {
            Balance = Balance - amount;
        }

        //public Account(double balance, string description, DateTime openingDate)
        //{
        //    Balance = balance;
        //    Description = description;
        //    OpeningDate = openingDate;
        //}
    }
}
