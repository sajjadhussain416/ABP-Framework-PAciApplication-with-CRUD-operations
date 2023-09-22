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
using PaciApplication.PaciServices;

namespace PaciApplication.Web.Pages.PaciSetting
{
    public class CreateModel : PageModel
    {
        private readonly IPaciSetting _PaciSettingService;

        [BindProperty]
        public PacciSettingDTO PaciSetting { get; set; }

        public CreateModel(IPaciSetting PaciSettingService)
        {
            _PaciSettingService = PaciSettingService;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            await _PaciSettingService.CreateAsync(PaciSetting);

            return RedirectToPage("./Index");
        }
    }
}

