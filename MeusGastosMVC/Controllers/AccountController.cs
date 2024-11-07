using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeusGastosMVC.Models;

namespace MeusGastosMVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            List<Account> contas = new List<Account>();
            contas.Add(new Account { Id = 1, Description = "Santander", OpeningDate = DateTime.Parse("2015-01-01") });
            contas.Add(new Account { Id = 1, Description = "Nubank", OpeningDate = DateTime.Parse("2020-01-01") });
            contas.Add(new Account { Id = 1, Description = "Caixa", OpeningDate = DateTime.Parse("2019-01-01") });


            return View(contas);
        }
    }
}
