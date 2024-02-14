using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z64.LicnostiPodatoci
{
    public class Licnost
    {
        private long maticenBroj;
        private string ime;
        private string tatkovoIme;
        private string prezime;
        private DateTime datum;
        private string adresa;
        private string mesto;
        private string klas;
        private string godinaUcebna;

        public long MaticenBroj
        {
            get { return maticenBroj; }
            set { maticenBroj = value; }
        }
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public string TatkovoIme
        {
            get { return tatkovoIme; }
            set { tatkovoIme = value; }
        }
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
        public DateTime Datum
        {
            get { return datum; }
            set { datum = value; }
        }
        public string Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }
        public string Mesto
        {
            get { return mesto; }
            set { mesto = value; }
        }
        public string Klas
        {
            get { return klas; }
            set { klas = value; }
        }

        public string GodinaUcebna
        {
            get { return godinaUcebna; }
            set { godinaUcebna = value; }
        }

    }
}
