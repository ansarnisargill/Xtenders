using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using XtendersProject.Data;
using XtendersProject.Models;

namespace XtendersProject.Quotaions
{
    public class DetailsModel : PageModel
    {
        private readonly XtendersProject.Data.Context _context;

        public DetailsModel(XtendersProject.Data.Context context)
        {
            _context = context;
        }

        public Quotation Quotation { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Quotation = await _context.Quotations.FirstOrDefaultAsync(m => m.ID == id);

            if (Quotation == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
