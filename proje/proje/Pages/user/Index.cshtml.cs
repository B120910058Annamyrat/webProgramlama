using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using proje.Models;

namespace proje.Pages.ius
{
    public class IndexModel : PageModel
    {
        private readonly proje.Models.PlaneVeriContext _context;

        public IndexModel(proje.Models.PlaneVeriContext context)
        {
            _context = context;
        }

        public IList<Kullanici> Kullanici { get;set; }

        public async Task OnGetAsync()
        {
            Kullanici = await _context.Kullanicis.ToListAsync();
        }
    }
}
