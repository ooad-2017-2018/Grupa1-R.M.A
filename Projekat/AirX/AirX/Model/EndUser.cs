using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirX.Model
{
    class EndUser : User
    {
        //private Image slika;
        private Let letovi;
        private Rezervacija rezervacije;
        //private Notifikacija notifikacije;
        private string opisProfila;
       // private tip tipKorisnika;

 
        /* public Image GetSlika()
        {
            return this.slika;
        }
        public void SetSlika(ref Image slika)
        {
            this.slika = slika;
        }
        */
        public Let GetLetovi()
        {
            return this.letovi;
        }
        public void SetLetovi(ref Let letovi)
        {
            this.letovi = letovi;
        }
        public Rezervacija GetRezervacije()
        {
            return this.rezervacije;
        }
        /*public Notifikacija GetNotifikacije()
        {
            return this.notifikacije;
        }
        public void SetNotifikacije(ref Notifikacija notifikacije)
        {
            this.notifikacije = notifikacije;
        }*/
        public string GetOpisProfila()
        {
            return this.opisProfila;
        }
        public void SetOpisProfila(ref string opisProfila)
        {
            this.opisProfila = opisProfila;
        }
		
        /*public Registrovani_Korisnik()
        {
            throw new System.Exception("Not implemented");
        }
        public tip GetTipKorisnika()
        {
            return this.tipKorisnika;
        }
        public void SetTipKorisnika(ref tip tipKorisnika)
        {
            this.tipKorisnika = tipKorisnika;
        }*/
        public string RezervacijaLeta(ref object rezervacija)
        {
            throw new System.Exception("Not implemented");
        }

        private Rezervacija[] rezervacijas;
        private Let[] lets;

        private Karta[] kartas;


    }
}
