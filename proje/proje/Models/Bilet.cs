using System;
using System.Collections.Generic;

#nullable disable

namespace proje.Models
{
    public partial class Bilet
    {
        public int Id { get; set; }
        public int KullaniciId { get; set; }
        public int SeferId { get; set; }
        public int BiletFiyati { get; set; }

        public virtual Kullanici Kullanici { get; set; }
        public virtual Sefer Sefer { get; set; }
    }
}
