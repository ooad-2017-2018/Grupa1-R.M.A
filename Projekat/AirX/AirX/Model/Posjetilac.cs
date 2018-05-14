using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirX.Model
{
    class Posjetilac : Pojedinac
    {
        private string username;
        private string password;
        private string email;
        //private Image slika;
        private Let letovi;
        private Rezervacija rezervacije;
       // private Notifikacija notifikacije;
        private string opisProfila;
        private string brojTelefona;
       // private tip tipKorisnika;

        public string GetUsername()
        {
            return this.username;
        }
        public void SetUsername(ref string username)
        {
            this.username = username;
        }
        public string GetPassword()
        {
            return this.password;
        }
        public void SetPassword(ref string password)
        {
            this.password = password;
        }
        public string GetEmail()
        {
            return this.email;
        }
        public void SetEmail(ref string email)
        {
            this.email = email;
        }
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
        public string GetBrojTelefona()
        {
            return this.brojTelefona;
        }
        public void SetBrojTelefona(ref string brojTelefona)
        {
            this.brojTelefona = brojTelefona;
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
