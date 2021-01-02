﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using proje.Models;

namespace proje.Pages
{
    public class _KalkisYeriPartialModel : PageModel
    {
        private readonly proje.Models.PlaneVeriContext _context;

        public _KalkisYeriPartialModel(proje.Models.PlaneVeriContext context)
        {
            _context = context;
        }

        public IList<Konum> Konum { get;set; }

        public async Task OnGetAsync()
        {
            Konum = await _context.Konumis
                .Include(k => k.UstKonum).ToListAsync();
        }
    }
}
