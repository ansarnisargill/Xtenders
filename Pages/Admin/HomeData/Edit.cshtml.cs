using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using XtendersProject.Data;
using XtendersProject.Models;

namespace XtendersProject.Home
{
    public class EditModel : PageModel
    {
        private readonly XtendersProject.Data.Context _context;

        public EditModel(XtendersProject.Data.Context context)
        {
            _context = context;
        }

        [BindProperty]
        public HomePageData HomePageData { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            HomePageData = await _context.HomeData.FirstOrDefaultAsync(m => m.ID == id);

            if (HomePageData == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(HomePageData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HomePageDataExists(HomePageData.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Details");
        }

        private bool HomePageDataExists(int id)
        {
            return _context.HomeData.Any(e => e.ID == id);
        }
    }
}
