using System.Collections.Generic;
using budget_app.DAL;
using budget_app.Models;
using Microsoft.AspNetCore.Mvc;

namespace budget_app.Controllers
{
    [Route("api/accounts")]
    public class AccountsController : Controller
    {
        private BudgetDbContext _context;

        public AccountsController(BudgetDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IActionResult GetAccounts()
        {
            var accounts = new List<Account>();
            return Ok(accounts);
        }
        
    }
}