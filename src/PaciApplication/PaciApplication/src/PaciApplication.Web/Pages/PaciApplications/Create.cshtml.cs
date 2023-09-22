using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PACIModel.Models;
using PaciApplication.EntityFrameworkCore;
using PaciApplication.PaciAppInterface;

namespace PaciApplication.Web.Pages.PaciApplications
{
    public class CreateModel : PageModel
    {

        private readonly IPaciiApplication _paciApplicationService;

        [BindProperty]
        public PaciiAPPlicationDTO PaciAplication { get; set; }

        public CreateModel(IPaciiApplication paciApplicationService)
        {
            _paciApplicationService = paciApplicationService;
        }

      

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _paciApplicationService.CreateAsync(PaciAplication);

            return RedirectToPage("./Index");
        }
    }
}

