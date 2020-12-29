using System;
using System.Collections.Generic;

#nullable disable

namespace proje.Models
{
    public partial class IletisimBilgileri
    {
        public int Id { get; set; }
        public string Konum { get; set; }
        public string Eposta { get; set; }
        public int TelNo { get; set; }
    }
}
