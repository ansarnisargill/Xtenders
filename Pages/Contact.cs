using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using XtendersProject.Data;
using XtendersProject.Models;

namespace XtendersProject.Pages
{
    public class ContactModel : PageModel
    {
        public Context _context { get; set; }
        public AboutUs AboutUs { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            AboutUs =await _context.AboutUs.FirstOrDefaultAsync();
            return Page();
        }
        public ContactModel(Context context)
        {
            _context = context;
        }
    }
}