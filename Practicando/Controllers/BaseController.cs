using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practicando.Models;

namespace Practicando.Controllers
{
    public abstract class BaseController : Controller
    {
        private readonly FinancistoContext _context;
        public BaseController(FinancistoContext context)
        {
            this._context = context;
        }
        protected User LoggedUser()
        {
            var claim = HttpContext.User.Claims.FirstOrDefault();
            var user = _context.Users.Where(o => o.Username == claim.Value).FirstOrDefault();
            return user;
        }
    }
}
