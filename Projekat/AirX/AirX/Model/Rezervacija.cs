using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirX.Model
{
    class Rezervacija
    {
		private static int idRezervacije;
        private string idPasos;
        private string idViza;
        private Int32 brojSjedista;
        private string hrana;
        private Int32 tezinaPrtljaga;
        private string klasa;
        private Int32 brojPutnika;
        private Let polazak;
        private Let povratak;

        public Rezervacija(string pasosId, string vizaId, int brojSjedis, string hrana, int tezinaPrtljaga, string klasa, int brojPutnika, Let polazak, Let povratak)
        {
            this.IdPasos = pasosId;
            this.IdViza = vizaId;
            this.BrojSjedista = brojSjedis;
            this.Hrana = hrana;
            this.TezinaPrtljaga = tezinaPrtljaga;
            this.Klasa = klasa;
            this.BrojPutnika = brojPutnika;
            this.Polazak = polazak;
            this.Povratak = povratak;
        }

        public static int IdRezervacije { get => idRezervacije; set => idRezervacije = value; }

        public string Hrana { get => hrana; set => hrana = value; }
        public int TezinaPrtljaga { get => tezinaPrtljaga; set => tezinaPrtljaga = value; }
        public string Klasa { get => klasa; set => klasa = value; }
        public int BrojPutnika { get => brojPutnika; set => brojPutnika = value; }
        public string IdPasos { get => idPasos; set => idPasos = value; }
        public string IdViza { get => idViza; set => idViza = value; }
        public int BrojSjedista { get => brojSjedista; set => brojSjedista = value; }
        internal Let Polazak { get => polazak; set => polazak = value; }
        internal Let Povratak { get => povratak; set => povratak = value; }
    }
}
