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
    public class DetailsModel : PageModel
    {
        private readonly proiect2.Data.proiect2Context _context;

        public DetailsModel(proiect2.Data.proiect2Context context)
        {
            _context = context;
        }

        public Food Food { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Food = await _context.Food.FirstOrDefaultAsync(m => m.ID == id);

            if (Food == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
