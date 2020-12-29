using System;
using System.Collections.Generic;

#nullable disable

namespace proje.Models
{
    public partial class Havalimanlari
    {
        public Havalimanlari()
        {
            Sefers = new HashSet<Sefer>();
        }

        public int Id { get; set; }
        public string Ad { get; set; }
        public int KonumId { get; set; }

        public virtual Konum Konum { get; set; }
        public virtual ICollection<Sefer> Sefers { get; set; }
    }
}
