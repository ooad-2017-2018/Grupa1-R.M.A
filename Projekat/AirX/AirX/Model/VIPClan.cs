using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirX.Model
{
    class VIPClan : Pojedinac
    {
        private string tipVIP;

        public string GetTipVIP()
        {
            return this.tipVIP;
        }
        public void SetTipVIP(string tipVIP)
        {
            this.tipVIP = tipVIP;
        }
        public void OdjavaVIP()
        {
            throw new System.Exception("Not implemented");
        }

    }
}
