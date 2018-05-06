using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirX.Model
{
    class Supervizor
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
        public string DodajLet(ref object let)
        {
            throw new System.Exception("Not implemented");
        }
        public string ObrisiLet(ref object let)
        {
            throw new System.Exception("Not implemented");
        }
        public string PosaljiNotifikacijuKorisniku(ref object notifikacija, ref object korisnik, ref object string_)
        {
            throw new System.Exception("Not implemented");
        }
        public string AzurirajLet(ref object let, ref object string_)
        {
            throw new System.Exception("Not implemented");
        }


    }
}
