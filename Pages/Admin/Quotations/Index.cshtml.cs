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
    public class IndexModel : PageModel
    {
        private readonly XtendersProject.Data.Context _context;

        public IndexModel(XtendersProject.Data.Context context)
        {
            _context = context;
        }

        public IList<Quotation> Quotation { get;set; }

        public async Task OnGetAsync()
        {
            Quotation = await _context.Quotations.ToListAsync();
        }
    }
}
