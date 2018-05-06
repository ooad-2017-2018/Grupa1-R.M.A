using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirX.Model
{
    class Karta
    {
        private string barkodId;
        private Korisnik korisnsik;
        private Let let;

        public string GetBarkodId()
        {
            return this.barkodId;
        }
        public void SetBarkodId(ref string barkodId)
        {
            this.barkodId = barkodId;
        }
        public Korisnik GetKorisnsik()
        {
            return this.korisnsik;
        }
        public void SetKorisnsik(ref Korisnik korisnsik)
        {
            this.korisnsik = korisnsik;
        }
        public Let GetLet()
        {
            return this.let;
        }
        public void SetLet(ref Let let)
        {
            this.let = let;
        }

        private Registrovani_Korisnik registrovani_Korisnik;

    }
}
