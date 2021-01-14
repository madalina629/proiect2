using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using proiect2.Data;
using proiect2.Models;

namespace proiect2.Pages.Foods
{
    public class IndexModel : PageModel
    {
        private readonly proiect2.Data.proiect2Context _context;

        public IndexModel(proiect2.Data.proiect2Context context)
        {
            _context = context;
        }

        public IList<Food> Food { get;set; }

        public async Task OnGetAsync()
        {
            Food = await _context.Food.ToListAsync();
        }
    }
}
