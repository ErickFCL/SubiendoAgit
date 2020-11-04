using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practicando.Models;

namespace Practicando.Controllers
{
    public class TransactionController : Controller
    {
        private readonly FinancistoContext _context;
        public TransactionController(FinancistoContext context)
        {
            this._context = context;
        }
        [HttpGet]
        public IActionResult Index(int accountId)
        {
            
            var transactions = _context.Transactions.Where(o => o.AccountId == accountId).ToList();
            ViewBag.AccountId = accountId;
            return View(transactions);
        }
        [HttpGet]
        public IActionResult Create(int accountId)
        {
            ViewBag.AccountId = accountId;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Transaction transaction )
        {
            if (!ModelState.IsValid)
            {
                ViewBag.AccountId = transaction.AccountId;
                return View(transaction);
            }
            //guardar transaction
            _context.Transactions.Add(transaction);
            _context.SaveChanges();
            var account = _context.Accounts.FirstOrDefault(o => o.Id == transaction.AccountId);
            if(transaction.Type == "GASTO")
                account.Amount -= transaction.Amount;
            else
                account.Amount += transaction.Amount;
            _context.SaveChanges();

            return RedirectToAction("Index", new { accountId = transaction.AccountId });
        }

    }
}
