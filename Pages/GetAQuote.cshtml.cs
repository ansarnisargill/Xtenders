using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using XtendersProject.Data;
using XtendersProject.Models;

namespace XtendersProject
{
    public class GetAQuoteModel : PageModel
    {
        private readonly Context _context;
        public List<Product> Products { get; set; }
        public GetAQuoteModel(Context context)
        {
            _context = context;
        }
        public async Task<IActionResult> OnGetAsync()
        {
            this.Products = await _context.Products.ToListAsync();
            return Page();
        }

    }
}