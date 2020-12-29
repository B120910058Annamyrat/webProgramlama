using System;
using System.Collections.Generic;

#nullable disable

namespace proje.Models
{
    public partial class Ucaklar
    {
        public Ucaklar()
        {
            Sefers = new HashSet<Sefer>();
        }

        public int Id { get; set; }
        public int Ad { get; set; }
        public byte KoltukSayisi { get; set; }

        public virtual ICollection<Sefer> Sefers { get; set; }
    }
}
