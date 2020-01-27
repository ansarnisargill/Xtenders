using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using XtendersProject.Data;
using XtendersProject.Models;

namespace XtendersProject.Pages
{
    public class LoginModel : PageModel
    {
        private readonly Context _context;
        [BindProperty]
        public User User { get; set; }
        public LoginModel(Context context)
        {
            _context = context;
        }
        public bool InvalidLogin { get; set; } = false;
        public IActionResult OnGetAsync()
        {
            if (HttpContext.Session.GetInt32("Id") != null)
            {
                return RedirectToPage("/Admin");
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _context.Users.Where(x => x.Username == this.User.Username && x.Password == this.User.Password).FirstOrDefaultAsync();
            if (user != null)
            {
                HttpContext.Session.SetInt32("Id", user.ID);
                return RedirectToPage("/Admin");
            }
            else
            {
                this.InvalidLogin = true;
                return Page();
            }
        }
    }
}
