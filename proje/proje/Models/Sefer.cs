using System;
using System.Collections.Generic;

#nullable disable

namespace proje.Models
{
    public partial class Sefer
    {
        public Sefer()
        {
            Bilets = new HashSet<Bilet>();
        }

        public int Id { get; set; }
        public int KalkisYeri { get; set; }
        public int InisYeri { get; set; }
        public DateTime SeferTarihi { get; set; }
        public int UcakId { get; set; }
        public byte YolcuSayisi { get; set; }
        public int HavalimanId { get; set; }

        public virtual Havalimanlari Havaliman { get; set; }
        public virtual Konum Konum { get; set; }
        public virtual Ucaklar Ucak { get; set; }
        public virtual ICollection<Bilet> Bilets { get; set; }
    }
}
