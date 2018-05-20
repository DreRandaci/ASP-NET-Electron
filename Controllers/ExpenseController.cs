using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using number_cruncher.Data;
using number_cruncher.Models;
using number_cruncher.Models.ExpenseViewModels;

namespace number_cruncher.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _iConfiguration;

        public ExpenseController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IConfiguration iConfiguration)
        {
            _userManager = userManager;
            _context = context;
            _iConfiguration = iConfiguration;
        }

        // This task retrieves the currently authenticated user
        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        // GET: Expenses
        public async Task<IActionResult> Index()
        {
            // get current user
            ApplicationUser user = await GetCurrentUserAsync();

            var expenses = await _context.Expense
                .Where(e => e.User == user)
                .ToListAsync();

            if (expenses == null | expenses.Count < 1)
            {
                return NotFound();
            }

            return View(expenses);
        }

        // GET: Expenses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expense = await _context.Expense
                .SingleOrDefaultAsync(n => n.ExpenseId == id);

            if (expense == null)
            {
                return NotFound();
            }

            return View(expense);
        }

        // POST: Notes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateExpenseViewModel expenseViewModel)
        {
            ModelState.Remove("expense.user");

            if (ModelState.IsValid)
            {
                // get current user
                ApplicationUser user = await GetCurrentUserAsync();
                // add current user
                expenseViewModel.Expense.User = user;

                _context.Add(expenseViewModel.Expense);
                await _context.SaveChangesAsync();

                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Index", "Home");
        }


        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
