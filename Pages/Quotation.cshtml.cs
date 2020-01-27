using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using XtendersProject.Data;
using XtendersProject.Models;

namespace XtendersProject.Pages
{
    public class QuotationModel : PageModel
    {
        public QuotationModel(Context context)
        {
            _context = context;
        }
        public Context _context { get; set; }
        public Product _product { get; set; }
        [BindProperty]
        public Quotation Quotation { get; set; }
        public IActionResult OnGet(int id)
        {
            _product = _context.Products.Find(id);
            return Page();
        }
        public async Task<IActionResult> OnPostAsync(){
            await _context.Quotations.AddAsync(Quotation);
            await _context.SaveChangesAsync();
            return Redirect("/Received");
        }
    }
}