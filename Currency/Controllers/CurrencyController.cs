using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Currency.Controllers
{
    public class CurrencyController : Controller
    {
        public IActionResult Index()
        {
            return View("myview");
        }

        public IActionResult transfer(float dollar, float rate)
        {
            Models.Currency cur = new Models.Currency(dollar, rate);
            cur.transfer();
            return View("myview", cur);
        }
    }
}
