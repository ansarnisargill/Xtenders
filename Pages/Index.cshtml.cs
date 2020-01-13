using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using XtendersProject.Data;
using XtendersProject.Models;

namespace XtendersProject.Pages
{
    public class IndexModel : PageModel
    {
        private Context _context;
        [BindProperty]
        public HomePageData homePageData { get; set; }
        public IActionResult OnGet()
        {
            this.homePageData = _context.HomeData.First();
            return Page();
        }
        public IndexModel(Context contex)
        {
            _context = contex;
        }
    }
}
