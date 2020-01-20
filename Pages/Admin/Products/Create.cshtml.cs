using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using XtendersProject.Data;
using XtendersProject.Models;

namespace XtendersProject
{
    public class CreateModel : PageModel
    {
        private readonly XtendersProject.Data.Context _context;
        private IHostingEnvironment _environment;
        public CreateModel(XtendersProject.Data.Context context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {

            Product.AddedDate = DateTime.Now;
            var file = Path.Combine(_environment.ContentRootPath, "wwwroot\\Images", Product.Pic.FileName.Replace(" ",""));
            using (var fileStream = new FileStream(file, FileMode.Create))
            {
                await Product.Pic.CopyToAsync(fileStream);
            }
            Product.PicUrl = $"/Images/{Product.Pic.FileName.Replace(" ", "")}";
            _context.Products.Add(Product);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}