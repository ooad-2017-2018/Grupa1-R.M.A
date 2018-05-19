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
        private EndUser korisnsik;
        private Let let;

        public string GetBarkodId()
        {
            return this.barkodId;
        }
        public void SetBarkodId(ref string barkodId)
        {
            this.barkodId = barkodId;
        }
        public EndUser GetKorisnsik()
        {
            return this.korisnsik;
        }
        public void SetKorisnsik(ref EndUser korisnsik)
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
    }
}
