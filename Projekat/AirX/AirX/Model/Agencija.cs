using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirX.Model
{
    class Agencija : Registrovani_Korisnik
    {
        private string imeAgencije;

        public void SetImeAgencije(ref string imeAgencije)
        {
            this.imeAgencije = imeAgencije;
        }
        public string PosaljiZahtjevZaNovuDestinaciju(ref object image)
        {
            throw new System.Exception("Not implemented");
        }
        public void RezervišiCijeliLet()
        {
            throw new System.Exception("Not implemented");
        }

    }

}
}
