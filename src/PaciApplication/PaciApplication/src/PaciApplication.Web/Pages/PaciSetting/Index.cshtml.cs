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
    public class IndexModel : PageModel
    {
        private readonly PaciApplication.EntityFrameworkCore.PaciApplicationDbContext _context;

        public IndexModel(PaciApplication.EntityFrameworkCore.PaciApplicationDbContext context)
        {
            _context = context;
        }

        public IList<PaciSettings> PaciSetting { get;set; } = default!;
       

        public async Task OnGetAsync()
        {
            if (_context.PaciSettings != null)
            {
                PaciSetting = await _context.PaciSettings.ToListAsync();
            }
        }
    }
}
