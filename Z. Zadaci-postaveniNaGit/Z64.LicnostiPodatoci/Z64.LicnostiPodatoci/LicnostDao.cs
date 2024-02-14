using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z64.LicnostiPodatoci
{
    public class LicnostDao : Licnost
    {
        private Database database = null;

        public LicnostDao(Database objDB)
        {
            this.database = objDB;
        }

        public void VnesiLicnost()
        {
            
            long maticen = this.MaticenBroj;
            string ime = this.Ime;
            string tatkovoIme = this.TatkovoIme;
            string prezime = this.Prezime;
            DateTime data = this.Datum;
            string adresa = this.Adresa;
            string mestoZiveenje = this.Mesto;
            string klas = this.Klas;
            string godinaUcebna = this.GodinaUcebna;

            string koloni = "maticen,ime,tatkovo_ime,prezime,data,adresa,mesto_ziveenje,klas,godina_ucebna";
            string koloniVrednosti =""+maticen+",'"+ime+ "','"+tatkovoIme+ "','"+prezime+"','"+data+"','"+adresa+"','"+mestoZiveenje+"','"+klas+"','"+godinaUcebna+"'";
            MessageBox.Show(koloniVrednosti);
            // Database  objDB = this.database;    
            this.database.Vnesi(koloni,koloniVrednosti);

        }
    }
}
