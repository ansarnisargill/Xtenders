using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using XtendersProject.Data;
using XtendersProject.Models;

namespace XtendersProject.Home
{
    public class DetailsModel : PageModel
    {
        private readonly XtendersProject.Data.Context _context;

        public DetailsModel(XtendersProject.Data.Context context)
        {
            _context = context;
        }

        public HomePageData HomePageData { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
           

            HomePageData = await _context.HomeData.FirstOrDefaultAsync();

            if (HomePageData == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
