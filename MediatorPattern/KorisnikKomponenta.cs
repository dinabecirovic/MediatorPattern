using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class KorisnikKomponenta : Komponenta
    {
        public KorisnikKomponenta(IPosrednik posrednik) : base(posrednik) { }

        public void RegistrujKorisnika(string korisnickoIme)
        {
            Console.WriteLine($"Korisnik {korisnickoIme} je registrovan.");
            posrednik.Obavesti(korisnickoIme, "KorisnikRegistrovan");
        }
    }
}

