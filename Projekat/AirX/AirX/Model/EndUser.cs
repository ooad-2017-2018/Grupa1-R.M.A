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
        private string opisProfila;

 
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
 
        public string GetOpisProfila()
        {
            return this.opisProfila;
        }
        public void SetOpisProfila(ref string opisProfila)
        {
            this.opisProfila = opisProfila;
        }
	
        
        public string RezervacijaLeta(ref object rezervacija)
        {
            throw new System.Exception("Not implemented");
        }

        private Rezervacija[] rezervacijas;
        private Let[] lets;

        private Karta[] kartas;


    }
}
