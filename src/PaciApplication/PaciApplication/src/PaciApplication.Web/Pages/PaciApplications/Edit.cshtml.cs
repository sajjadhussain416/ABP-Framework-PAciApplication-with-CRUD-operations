using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PACIModel.Models;
using PaciApplication.PaciAppInterface;

namespace PaciApplication.Web.Pages.PaciApplications
{
    public class EditModel : PageModel
    {
        private readonly IPaciiApplication _paciApplicationService;
        private readonly PaciApplication.EntityFrameworkCore.PaciApplicationDbContext _context;

        public EditModel(IPaciiApplication paciApplicationService, PaciApplication.EntityFrameworkCore.PaciApplicationDbContext context)
        {
            _paciApplicationService = paciApplicationService;
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

            var paciaplication = await _context.PaciApplications.FirstOrDefaultAsync(m => m.PaciApplicationId == id);
            if (paciaplication == null)
            {
                return NotFound();
            }
            PaciAplication = paciaplication;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                //_context.Attach(PaciAplication).State = EntityState.Modified;

                var paciaplication = await _context.PaciApplications.FirstOrDefaultAsync(m => m.PaciApplicationId == PaciAplication.PaciApplicationId);
                
                if (paciaplication == null)
                {
                    return NotFound();
                }

             
                PaciiAPPlicationDTO updatedDto = new PaciiAPPlicationDTO
                {
                    Id= paciaplication.Id,
                    PaciApplicationId= PaciAplication.PaciApplicationId,
                    ApplicationName = PaciAplication.ApplicationName,
                    ApplicationDescriptionAr = PaciAplication.ApplicationDescriptionAr,
                    ApplicationDescriptionEn = PaciAplication.ApplicationDescriptionEn,
                    ReasonAr = PaciAplication.ReasonAr,
                    ReasonEn = PaciAplication.ReasonEn,
                    Challange = PaciAplication.Challange,
                    IsEnabled = PaciAplication.IsEnabled,
                    CreatedBy = PaciAplication.CreatedBy,
                    CreatedDate = PaciAplication.CreatedDate,

                    ApplicationGuidId = PaciAplication.ApplicationGuidId
       


                };

                var updatedPaciApplication = await _paciApplicationService.UpdateAsync(updatedDto.Id, updatedDto);
                return RedirectToPage("./Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "An error occurred while updating the PaciApplication.");
                return Page();
            }
        }


        private bool PaciAplicationExists(int id)
        {
            return (_context.PaciApplications?.Any(e => e.PaciApplicationId == id)).GetValueOrDefault();
        }
    }
}
