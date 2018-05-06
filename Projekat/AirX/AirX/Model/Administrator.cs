using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirX.Model
{
    class Administrator
    {
        private string imeIPrezime;
        private string username;
        private string password;

        public string GetImeIPrezime()
        {
            return this.imeIPrezime;
        }
        public void SetImeIPrezime(ref string imeIPrezime)
        {
            this.imeIPrezime = imeIPrezime;
        }
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
        public string ObrisiKorisnika(ref object registrovaniKorisnik)
        {
            throw new System.Exception("Not implemented");
        }
        public string ObrisiSupervizora(ref object supervizor)
        {
            throw new System.Exception("Not implemented");
        }
        public string ObrisiRecepciju(ref object recepcija)
        {
            throw new System.Exception("Not implemented");
        }
        

    }

}
