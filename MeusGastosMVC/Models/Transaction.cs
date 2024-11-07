using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeusGastosMVC.Models.Enum;
using MeusGastosMVC.Models;

namespace MeusGastosMVC.Models
{
    public class Transaction
    {

        //      Transaction
        //- date: date
        //- amount: decimal
        //- type: enum { INCOME, EXPENSE }
        //- category: Category
        //+ calculateTotalByCategory() : decimal
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public TypeTransaction TypeTransaction { get; set; }
        public Category Category { get; set; }

        public double calculateTotalByCategory(IEnumerable<Transaction> transacoes, Category category)
        {     
            return transacoes.Where(t => t.Category == category).Sum(t => t.Amount);
        }
    }
}
