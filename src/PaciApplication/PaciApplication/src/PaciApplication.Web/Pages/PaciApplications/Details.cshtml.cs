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
    public class DetailsModel : PageModel
    {
        private readonly PaciApplication.EntityFrameworkCore.PaciApplicationDbContext _context;

        public DetailsModel(PaciApplication.EntityFrameworkCore.PaciApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
