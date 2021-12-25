using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yaoda_E_Shop.Data;

namespace Yaoda_E_Shop.Controllers
{
    public class SneakersController : Controller
    {
        private readonly AppDbContext _context;
        public SneakersController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allSneakers = await _context.Sneakers.ToListAsync();
            return View(allSneakers);
        }
    }
}
