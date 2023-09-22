using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PACIModel.Models;
using PaciApplication.EntityFrameworkCore;

namespace PaciApplication.Web.Pages.PaciSetting
{
    public class DeleteModel : PageModel
    {
        private readonly PaciApplication.EntityFrameworkCore.PaciApplicationDbContext _context;

        public DeleteModel(PaciApplication.EntityFrameworkCore.PaciApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public PaciSettings PaciSetting { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.PaciSettings == null)
            {
                return NotFound();
            }

            var pacisetting = await _context.PaciSettings.FirstOrDefaultAsync(m => m.PaciSettingId == id);

            if (pacisetting == null)
            {
                return NotFound();
            }
            else 
            {
                PaciSetting = pacisetting;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.PaciSettings == null)
            {
                return NotFound();
            }
            var pacisetting = await _context.PaciSettings.FindAsync(id);

            if (pacisetting != null)
            {
                PaciSetting = pacisetting;
                _context.PaciSettings.Remove(PaciSetting);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
