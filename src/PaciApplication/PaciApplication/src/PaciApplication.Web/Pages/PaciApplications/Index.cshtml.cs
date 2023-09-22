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
    public class IndexModel : PageModel
    {
        private readonly PaciApplication.EntityFrameworkCore.PaciApplicationDbContext _context;

        public IndexModel(PaciApplication.EntityFrameworkCore.PaciApplicationDbContext context)
        {
            _context = context;
        }

        public IList<PaciAplication> PaciAplication { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.PaciApplications != null)
            {
                PaciAplication = await _context.PaciApplications.ToListAsync();
            }
        }
    }
}
