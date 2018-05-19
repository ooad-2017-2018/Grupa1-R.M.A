using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirX.Model
{
    class Administrator : User
    {
        public Administrator(string givenName, string surname, bool gender, DateTime birthDate, string birthPlace, string nationality, string physicalAdress, string phoneNumber, string userName, string email, string password) : base(givenName, surname, gender, birthDate, birthPlace, nationality, physicalAdress, phoneNumber, userName, email, password)
        {
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
