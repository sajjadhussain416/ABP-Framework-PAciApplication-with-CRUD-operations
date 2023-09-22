using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PACIModel.Models;
using PaciApplication.EntityFrameworkCore;
using PaciApplication.PaciAppInterface;
using PaciApplication.PaciServices;

namespace PaciApplication.Web.Pages.PaciSetting
{
    public class EditModel : PageModel
    {
        private readonly IPaciSetting _PaciSettingService;
        private readonly PaciApplication.EntityFrameworkCore.PaciApplicationDbContext _context;

        public EditModel(IPaciSetting PaciSettingService, PaciApplication.EntityFrameworkCore.PaciApplicationDbContext context)
        {
            _PaciSettingService = PaciSettingService;
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
         

            var PaciSettingss = await _context.PaciSettings.FirstOrDefaultAsync(m => m.PaciSettingId == id);
            if (PaciSettingss == null)
            {
                return NotFound();
            }

            PaciSetting = PaciSettingss;
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

                var paciSettings = await _context.PaciSettings.FirstOrDefaultAsync(m => m.PaciSettingId == PaciSetting.PaciSettingId);

                if (paciSettings == null)
                {
                    return NotFound();
                }

                
                PacciSettingDTO obj = new PacciSettingDTO()
                 {
                     Id = paciSettings.Id,
                     PaciSettingId = PaciSetting.PaciSettingId,
                     SettingName = PaciSetting.SettingName,
                    SettingValue = paciSettings.SettingValue,
                    IsDisabled = PaciSetting.IsDisabled,
                     CreatedBy = PaciSetting.CreatedBy,
                     CreatedDate = PaciSetting.CreatedDate,
                     ModifiedBy = PaciSetting.ModifiedBy,
                     ModifiedDate = PaciSetting.ModifiedDate,
                     FlexColumn1 = PaciSetting.FlexColumn1,
                     FlexColumn2 = PaciSetting.FlexColumn2,



                 };

                //obj.Id=paciSettings.Id;
                //obj.PaciSettingId = paciSettings.PaciSettingId;
                //obj.SettingName = paciSettings.SettingName;
                //obj.SettingValue = paciSettings.SettingValue;
                //obj.IsDisabled = paciSettings.IsDisabled;
                //obj.CreatedBy = paciSettings.CreatedBy;
                //obj.CreatedDate= paciSettings.CreatedDate;
                //obj.ModifiedBy=paciSettings.ModifiedBy;
                //obj.ModifiedDate = paciSettings.ModifiedDate;
                //obj.FlexColumn1 = paciSettings.FlexColumn1;
                //obj.FlexColumn2 = paciSettings.FlexColumn2;







                var paciseetingupdate = await _PaciSettingService.UpdateAsync(obj.Id, obj);
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
            return (_context.PaciSettings?.Any(e => e.PaciSettingId == id)).GetValueOrDefault();
        }
    }
}
