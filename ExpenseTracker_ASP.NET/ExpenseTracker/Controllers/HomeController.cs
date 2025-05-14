using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using ExpenseTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ExpensesDbContext _context;

        public HomeController(ILogger<HomeController> logger, ExpensesDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Expenses()
        {
            var allExpenses = _context.Expenses.ToList();
            return View(allExpenses);
            var totalexpense = allExpenses.Sum(expense => expense.Value);
            ViewBag.Expenses = totalexpense;
            return View();

        }
        public IActionResult CreateEditExpense(int? id)
        {
            if (id != null)
            {
                var expenseInDb = _context.Expenses.SingleOrDefault(expense => expense.Id == id);
                return View(expenseInDb);

            }

            return View();
        }
        public IActionResult DeleteExpense(int id)
        {
            var expenseInDb = _context.Expenses.SingleOrDefault(expense=> expense.Id==id);
            _context.Expenses.Remove(expenseInDb);
            _context.SaveChanges();
            return RedirectToAction("Expenses");
           
        }
        public IActionResult CreateEditExpenseForm(Expense model)
        {
            {
                if (model.Id == 0)
                {
                    // Create
                    _context.Expenses.Add(model);
                }
                else
                {
                    // Update
                    var existingExpense = _context.Expenses.SingleOrDefault(e => e.Id == model.Id);
                    if (existingExpense == null)
                    {
                        return NotFound();
                    }


                }

                _context.SaveChanges();
                return RedirectToAction("Expenses");
            }
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
