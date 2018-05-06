using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirX.Model
{
    class Pojedinac
    {
        private bool daLiJeVIP;
        private string imeIPrezime;
        private string adresa;
        private string drzava;
        private string grad;
        private enum Spol;

        public Boolean GetDaLiJeVIP()
        {
            throw new System.Exception("Not implemented");
        }
        public string GetImeIPrezime()
        {
            return this.imeIPrezime;
        }
        public void SetImeIPrezime(ref string imeIPrezime)
        {
            this.imeIPrezime = imeIPrezime;
        }
        public string GetAdresa()
        {
            return this.adresa;
        }
        public void SetAdresa(ref string adresa)
        {
            this.adresa = adresa;
        }
        public string GetDrzava()
        {
            return this.drzava;
        }
        public void SetDrzava(ref string drzava)
        {
            this.drzava = drzava;
        }
        public string GetGrad()
        {
            return this.grad;
        }
        public void SetGrad(ref string grad)
        {
            this.grad = grad;
        }
        public enum GetSpol() {
            return this.spol;
        }
        public void SetSpol(ref enum spol) {

            this.spol = spol;

        }


}
}
