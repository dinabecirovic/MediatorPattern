using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class OglasKomponenta : Komponenta
    {
        public OglasKomponenta(IPosrednik posrednik) : base(posrednik) { }

        public void UpravljajNoviKorisnik(string korisnickoIme)
        {
            Console.WriteLine($"OglasKomponenta: Novi korisnik je registrovan - {korisnickoIme}.");
        }
    }
}

