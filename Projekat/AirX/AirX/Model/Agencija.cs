using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirX.Model
{
    class Agencija : User
    {
        private string imeAgencije;

        public Agencija(string imeAgencije, string givenName, string surname, bool gender, DateTime birthDate, string birthPlace, string nationality, string physicalAdress, string phoneNumber, string userName, string email, string password) : base(givenName, surname, gender, birthDate, birthPlace, nationality, physicalAdress, phoneNumber, userName, email, password)
        {
            ImeAgencije = imeAgencije;
        }

        public string ImeAgencije { get => imeAgencije; set => imeAgencije = value; }


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

