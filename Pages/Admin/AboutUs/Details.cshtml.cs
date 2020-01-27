using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using XtendersProject.Data;
using XtendersProject.Models;

namespace XtendersProject.About
{
    public class DetailsModel : PageModel
    {
        private readonly XtendersProject.Data.Context _context;

        public DetailsModel(XtendersProject.Data.Context context)
        {
            _context = context;
        }

        public AboutUs AboutUs { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {

            AboutUs = await _context.AboutUs.FirstOrDefaultAsync();

            if (AboutUs == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
