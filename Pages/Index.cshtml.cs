using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using XtendersProject.Data;
using XtendersProject.Models;

namespace XtendersProject.Pages
{
    public class IndexModel : PageModel
    {
        private Context _context;
        [BindProperty]
        public HomePageData homePageData { get; set; }
        public List<Product> Products { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            this.homePageData =await _context.HomeData.FirstAsync();
            this.Products =await _context.Products.ToListAsync();
            return Page();
        }
        public IndexModel(Context contex)
        {
            _context = contex;
        }
    }
}
