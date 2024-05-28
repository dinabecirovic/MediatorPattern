using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class ZamenaDomovaPosrednik : IPosrednik
    {
        private KorisnikKomponenta korisnikKomponenta;
        private OglasKomponenta oglasKomponenta;

        public void RegistrujKorisnikKomponentu(KorisnikKomponenta komponenta)
        {
            korisnikKomponenta = komponenta;
            komponenta.PostaviPosrednika(this);
        }

        public void RegistrujOglasKomponentu(OglasKomponenta komponenta)
        {
            oglasKomponenta = komponenta;
            komponenta.PostaviPosrednika(this);
        }

        public void Obavesti(object posiljalac, string dogadjaj)
        {
            if (dogadjaj == "KorisnikRegistrovan")
            {
                oglasKomponenta.UpravljajNoviKorisnik((string)posiljalac);
            }
        }
    }
}

