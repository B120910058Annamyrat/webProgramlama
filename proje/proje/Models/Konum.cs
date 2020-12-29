using System;
using System.Collections.Generic;

#nullable disable

namespace proje.Models
{
    public partial class Konum
    {
        public Konum()
        {
            Havalimanlaris = new HashSet<Havalimanlari>();
            InverseUstKonum = new HashSet<Konum>();
        }

        public int Id { get; set; }
        public string Konum1 { get; set; }
        public int? UstKonumId { get; set; }

        public virtual Konum UstKonum { get; set; }
        public virtual ICollection<Havalimanlari> Havalimanlaris { get; set; }
        public virtual ICollection<Konum> InverseUstKonum { get; set; }
    }
}
