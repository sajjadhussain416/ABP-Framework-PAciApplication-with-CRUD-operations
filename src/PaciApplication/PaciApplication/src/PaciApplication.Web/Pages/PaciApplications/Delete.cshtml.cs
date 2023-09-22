using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PACIModel.Models;
using PaciApplication.EntityFrameworkCore;

namespace PaciApplication.Web.Pages.PaciApplications
{
    public class DeleteModel : PageModel
    {
        private readonly PaciApplication.EntityFrameworkCore.PaciApplicationDbContext _context;

        public DeleteModel(PaciApplication.EntityFrameworkCore.PaciApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public PaciAplication PaciAplication { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.PaciApplications == null)
            {
                return NotFound();
            }

            var paciaplication = await _context.PaciApplications.FirstOrDefaultAsync(m => m.PaciApplicationId.Equals(id));

            if (paciaplication == null)
            {
                return NotFound();
            }
            else 
            {
                PaciAplication = paciaplication;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.PaciApplications == null)
            {
                return NotFound();
            }
            var paciaplication = await _context.PaciApplications.FindAsync(id);

            if (paciaplication != null)
            {
                PaciAplication = paciaplication;
                _context.PaciApplications.Remove(PaciAplication);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
