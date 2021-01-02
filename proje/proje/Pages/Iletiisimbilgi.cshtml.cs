using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using proje.Models;

namespace proje.Pages.Iletisim
{
    public class IletiisimbilgiModel : PageModel
    {
        private readonly proje.Models.PlaneVeriContext _context;

        public IletiisimbilgiModel(proje.Models.PlaneVeriContext context)
        {
            _context = context;
        }

        public IList<IletisimBilgileri> IletisimBilgileri { get;set; }

        public async Task OnGetAsync()
        {
            IletisimBilgileri = await _context.IletisimBilgileris.ToListAsync();
        }
    }
}
