using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirX.Model
{
    class Rezervacija
    {
        private string pasosId;
        private string vizaId;
        private Int32 brojSjedis;
        private string hrana;
        private Int32 tezinaPrtljaga;
        private string klasa;
        private Int32 brojPutnika;
        private Let polazak;
        private Let povratak;

        public Rezervacija(string pasosId, string vizaId, int brojSjedis, string hrana, int tezinaPrtljaga, string klasa, int brojPutnika, Let polazak, Let povratak)
        {
            this.PasosId = pasosId;
            this.VizaId = vizaId;
            this.BrojSjedis = brojSjedis;
            this.Hrana = hrana;
            this.TezinaPrtljaga = tezinaPrtljaga;
            this.Klasa = klasa;
            this.BrojPutnika = brojPutnika;
            this.Polazak = polazak;
            this.Povratak = povratak;
        }

        public string PasosId { get => pasosId; set => pasosId = value; }
        public string VizaId { get => vizaId; set => vizaId = value; }
        public int BrojSjedis { get => brojSjedis; set => brojSjedis = value; }
        public string Hrana { get => hrana; set => hrana = value; }
        public int TezinaPrtljaga { get => tezinaPrtljaga; set => tezinaPrtljaga = value; }
        public string Klasa { get => klasa; set => klasa = value; }
        public int BrojPutnika { get => brojPutnika; set => brojPutnika = value; }
        internal Let Polazak { get => polazak; set => polazak = value; }
        internal Let Povratak { get => povratak; set => povratak = value; }
    }
}
