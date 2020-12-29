using System;
using System.Collections.Generic;

#nullable disable

namespace proje.Models
{
    public partial class Kullanici
    {
        public Kullanici()
        {
            Bilets = new HashSet<Bilet>();
        }

        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string TelNo { get; set; }
        public string Password { get; set; }
        public DateTime DogumTarih { get; set; }
        public int KimlikNo { get; set; }
        public int KullaniciTuru { get; set; }
        public byte[] Cinsiyet { get; set; }

        public virtual ICollection<Bilet> Bilets { get; set; }
    }
}
