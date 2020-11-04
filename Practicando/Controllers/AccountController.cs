using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Practicando.Models;

namespace Practicando.Controllers
{
    [Authorize]
    public class AccountController : BaseController
    {
        private FinancistoContext _context;
        [Obsolete]
        public IHostingEnvironment _hostEnv;

        [Obsolete]
        public AccountController(FinancistoContext context,IHostingEnvironment hostEnv):base(context)
        {
            this._context = context;
            this._hostEnv = hostEnv;
        }
        [HttpGet]
        public ActionResult Index()
        {
            var accounts = _context.Accounts
                .Where(o => o.UserId == LoggedUser().Id)
                .Include(o =>o.Type).
                ToList();
            return View(accounts);
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Types = _context.Types.ToList();
            return View(new Account());
        }
        [HttpPost]
        [Obsolete]
        public ActionResult Create(Account account,IFormFile Image)
        {
            
            if (ModelState.IsValid)
            {
                if(Image != null && Image.Length > 0)
                {
                    var basePath = _hostEnv.ContentRootPath + @"\wwwroot";
                    var ruta = @"\Files\" + Image.FileName;
                    using (var strem = new FileStream(basePath + ruta, FileMode.Create))
                    {
                        Image.CopyTo(strem);
                    }
                    account.ImagePath = ruta;
                }
                account.UserId = LoggedUser().Id;
                _context.Accounts.Add(account);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Types = _context.Types.ToList();
            return View("Create");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            ViewBag.Types = _context.Types.ToList();
            var account = _context.Accounts.Where(o => o.Id == id).FirstOrDefault();
            return View(account);
        }
        [HttpPost]
        public ActionResult Edit(Account account)
        {
            if (ModelState.IsValid)
            {
                _context.Accounts.Update(account);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Account = _context.Types.ToList();
           
            return View();
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var account = _context.Accounts.Where(o => o.Id == id).FirstOrDefault();
            _context.Accounts.Remove(account);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
