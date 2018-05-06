using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirX.Model
{
    class Let
    {
        private string polaziste;
        private string destinacija;
        private DateTime datum;
        private int brojSjedista;
        private double cijena;

        public Let(string polaziste, string destinacija, DateTime datum, int brojSjedista, double cijena)
        {
            this.polaziste = polaziste;
            this.destinacija = destinacija;
            this.datum = datum;
            this.brojSjedista = brojSjedista;
            this.cijena = cijena;
        }
    }
}
