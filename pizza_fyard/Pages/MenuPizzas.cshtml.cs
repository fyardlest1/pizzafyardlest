using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using pizza_fyard.Models;

namespace pizza_fyard.Pages
{
    public class MenuPizzasModel : PageModel
    {
        private readonly pizza_fyard.Data.DataContext _context;

        public MenuPizzasModel(pizza_fyard.Data.DataContext context)
        {
            _context = context;
        }

        public IList<Pizza> Pizza { get; set; }

        public async Task OnGetAsync()
        {
            Pizza = await _context.Pizzas.ToListAsync();
            // Afficher les pizzas pas ordre alphabetique
            Pizza = Pizza.OrderBy(p => p.price).ToList();
        }
    }
}
