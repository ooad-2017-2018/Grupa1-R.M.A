using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirX.Model
{
    class Recepcija
    {
        private string username;
        private string password;

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
        public void OcitajBarKod()
        {
            throw new System.Exception("Not implemented");
        }

    }
}
