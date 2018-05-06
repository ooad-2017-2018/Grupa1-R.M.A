﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirX.Model
{
    class AirX
    {
        private static List<Korisnik> = new List<Korisnik>();
        private static List<Supervizor> = new List<Supervizor>();
        private static Administrator = new Administrator();
        private static List<Recepcija> = new List<Recepcija>();
        private static List<Let> = new List<Let>();

        public RegistrovaniKorisnik GetKorisnici()
        {
            return this.korisnici;
        }
        public void SetKorisnici(ref RegistrovaniKorisnik korisnici)
        {
            this.korisnici = korisnici;
        }
        public Let GetLetovi()
        {
            return this.letovi;
        }
        public void SetLetovi(ref Let letovi)
        {
            this.letovi = letovi;
        }
        public Supervizor GetSupervizori()
        {
            return this.supervizori;
        }
        public void SetSupervizori(ref Supervizor supervizori)
        {
            this.supervizori = supervizori;
        }
        public Admin GetAdministrator()
        {
            return this.administrator;
        }
        public void SetAdministrator(ref Admin administrator)
        {
            this.administrator = administrator;
        }
        public Recepcija GetRecepcije()
        {
            return this.recepcije;
        }
        public void SetRecepcije(ref Recepcija recepcije)
        {
            this.recepcije = recepcije;
        }
        


    }
}
