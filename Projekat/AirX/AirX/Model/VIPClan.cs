using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirX.Model
{
    class VIPClan : User
    {
        private string tipVIP;
        private DateTime vrijemePocetkaVIP;

        public DateTime VrijemePocetkaVIP { get => vrijemePocetkaVIP; set => vrijemePocetkaVIP = value; }
        public string TipVIP { get => tipVIP; set => tipVIP = value; }

        public VIPClan(string TipVIP, string givenName, string surname, bool gender, DateTime birthDate, string birthPlace, string nationality, string physicalAdress, string phoneNumber, string userName, string email, string password) : base(givenName, surname, gender, birthDate, birthPlace, nationality, physicalAdress, phoneNumber, userName, email, password)
        {
            VrijemePocetkaVIP = DateTime.Today; 

        }

        public void OdjavaVIP()
        {
            throw new System.Exception("Not implemented");
        }

    }
}
