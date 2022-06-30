using MAXIM.DAL;
using MAXIM.Exsist;
using MAXIM.Models;
using MAXIM.Utilits;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MAXIM.Areas.adminpanel.Controllers
{
    [Area("adminpanel")]
    public class CardController : Controller
    {
        private readonly AppDbContext _context;
        private readonly WebHostBuilder webHostBuilder;

        public CardController(AppDbContext context, WebHostBuilder webHostBuilder)
        {
            _context = context;
            this.webHostBuilder = webHostBuilder;
        }
        public async Task<IActionResult> Index()
        {
            List<Card> cards = await _context.cards.ToListAsync();

            return View(cards);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> create(Card card)
        {
            if (!ModelState.IsValid) return View();
            if (card.Photo != null)
            {
                if (!card.Photo.IsExsist(1))
                {
                    ModelState.AddModelError("Photo", "Mb coxdur");
                    return View();
                }

                string Filestream = await card.Photo.FileCreate();
            }
        }
    }
}
