using System;

namespace MediatorPattern
{
    class Program
    {
        static void Main()
        {
            ZamenaDomovaPosrednik posrednik = new ZamenaDomovaPosrednik();

            KorisnikKomponenta korisnikKomponenta = new KorisnikKomponenta(posrednik);
            OglasKomponenta oglasKomponenta = new OglasKomponenta(posrednik);

            posrednik.RegistrujKorisnikKomponentu(korisnikKomponenta);
            posrednik.RegistrujOglasKomponentu(oglasKomponenta);

            korisnikKomponenta.RegistrujKorisnika("Haris");
        }
    }
}

