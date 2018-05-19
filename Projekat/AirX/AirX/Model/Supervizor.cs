using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirX.Model
{
    class Supervizor : User
    {
        public Supervizor(string givenName, string surname, bool gender, DateTime birthDate, string birthPlace, string nationality, string physicalAdress, string phoneNumber, string userName, string email, string password) : base(givenName, surname, gender, birthDate, birthPlace, nationality, physicalAdress, phoneNumber, userName, email, password)
        {
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
