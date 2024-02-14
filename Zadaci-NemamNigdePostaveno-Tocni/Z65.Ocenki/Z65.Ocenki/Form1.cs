using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

using Microsoft.Office.Interop.Excel;

namespace Z65.Ocenki
{
    public partial class Form1 : Form
    {
        static public string prosekKlas;

        static public List<string> prosekUcenikIme = new List<string>();
        static public List<string> prosekUcenikProsek = new List<string>();

        static public List<string> prosekPredmetIme = new List<string>();
        static public List<string> prosekPredmetProsek = new List<string>();

        static public List<string[]> distribucijaOcenkiLista = new List<string[]>();
        static public List<string[]>otstapvanjeOcenkiLista=new List<string[]>();
        static public List<string[]> slabiOcenkiLista = new List<string[]>();


        private Excel.Application ExcelObj = null;
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            //listView1.Columns.Add("id", 300);
            //listView1.Columns.Add("predmeti", 300);

            ExcelObj = new Excel.Application();
            // See if the Excel Application Object was successfully constructed  
            if (ExcelObj == null)
            {
                MessageBox.Show("ERROR: EXCEL couldn't be started!");
                System.Windows.Forms.Application.Exit();
            }
            // Make the Application Visible  
            ExcelObj.Visible = true;
        }

        static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source= C:\\SQLite\\Z65.Ocenki.db; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Problem so povrzuvanjeto so bazata");
            }
            return sqlite_conn;
        }
        public SQLiteDataReader ReadData(SQLiteConnection conn, string imeNaTabela)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM " + imeNaTabela;


            sqlite_datareader = sqlite_cmd.ExecuteReader();
            return sqlite_datareader;
        }

        static void CreateTableA(SQLiteConnection conn, List<string> lisView, string imeNaTabela)
        {

            SQLiteCommand sqlite_cmd;

            //proverka dali postoi tabela vo bazata
            string daliPostoiTabela = "SELECT name FROM sqlite_master WHERE type = 'table' AND name = '" + imeNaTabela + "'";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = daliPostoiTabela;
            var exists = sqlite_cmd.ExecuteReader();
            // List<string> lisView = new List<string>() { "id", "ime", "prezime", "godini" };
            if (!exists.HasRows)
            {
                //string createTable = "CREATE TABLE Licnosti(id INTEGER PRIMARY KEY,ime VARCHAR(20),prezime VARCHAR(40),godini INT)";

                string createTable = "CREATE TABLE " + imeNaTabela + "(";
                for (int i = 0; i < lisView.Count; i++)
                {
                    if (i < lisView.Count - 1)
                        createTable = createTable + lisView[i] + " VARCHAR(40),";
                    else
                    {
                        createTable = createTable + lisView[i] + " VARCHAR(40)) ";

                    }

                }

                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = createTable;
                sqlite_cmd.ExecuteNonQuery();
            }

        }
        public void InsertRow(SQLiteConnection conn, List<string> listView, List<string> listValues, string imeNaTabela)
        {

            //SQLiteConnection sqlite_conn;
            //sqlite_conn = CreateConnection();
            try
            {
                SQLiteCommand cmd;
                cmd = conn.CreateCommand();
                string insertInto = "INSERT INTO " + imeNaTabela + "(";
                for (int i = 0; i < listView.Count; i++)
                {
                    if (i < listView.Count - 1)
                    {
                        insertInto = insertInto + listView[i] + ", ";
                    }
                    else
                    {
                        insertInto = insertInto + listView[i] + " )";
                    }
                }
                insertInto = insertInto + " VALUES(";
                for (int i = 0; i < listValues.Count; i++)
                {
                    if (i < listValues.Count - 1)
                    {
                        insertInto = insertInto + "'" + listValues[i] + "', ";
                    }
                    else
                    {
                        insertInto = insertInto + "'" + listValues[i] + "' )";
                    }

                }
                cmd.CommandText = insertInto;

                for (int a = 0; a < listView.Count; a++)
                {
                    for (int j = a; j < listValues.Count; j++)
                    {
                        cmd.Parameters.AddWithValue(listView[a], listValues[j]);
                        break;
                    }

                }//63.1.BazaRazlicniKoloni
                //  MessageBox.Show(cmd.CommandText.ToString());


                cmd.ExecuteNonQuery();
                //   MessageBox.Show("Uspesno zapisvuvanje vo tabelata");

            }
            catch (System.Exception excpt)
            {
                MessageBox.Show("Problem so insert " + excpt);
            }
        }

        string[] ConvertToStringArray(System.Array values)
        {
            // create a new string array  
            string[] theArray = new string[values.Length];
            // loop through the 2-D System.Array and populate the 1-D String Array  
            for (int i = 1; i <= values.Length; i++)
            {
                if (values.GetValue(1, i) == null)
                    theArray[i - 1] = "";
                else
                    theArray[i - 1] = (string)values.GetValue(1, i).ToString();
            }
            return theArray;
        }

        private void btnPrezemiPodatoci_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            try
            {

                this.openFileDialog1.FileName = "*.xls"; if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //  MessageBox.Show(openFileDialog1.FileName);
                    // Here is the call to Open a Workbook in Excel   
                    // It uses most of the default values (except for the read-only which we set to true)  
                    Excel.Workbook theWorkbook = ExcelObj.Workbooks.Open(openFileDialog1.FileName, 0, true, 5,
                    "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true);
                    // get the collection of sheets in the workbook  
                    Excel.Sheets sheets = theWorkbook.Worksheets;
                    // get the first and only worksheet from the collection of worksheets  
                    Excel.Worksheet worksheet = (Excel.Worksheet)sheets.get_Item(1);
                    // loop through 10 rows of the spreadsheet and place each row in the list view  

                    int lastUsedRow = 0;
                    lastUsedRow = worksheet.Cells.Find("*", System.Reflection.Missing.Value,
                                                   System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                                                   Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlPrevious,
                                                   false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;

                    for (int i = 4; i <= 7; i++)
                    {
                        Excel.Range range = worksheet.get_Range("A" + i.ToString(), "M" + i.ToString());
                        System.Array myvalues = (System.Array)range.Cells.Value;
                        string[] strArray = ConvertToStringArray(myvalues);

                        foreach (var strAr in strArray)
                        {

                            if (strAr != "")
                            {
                                string result = strAr.Replace(' ', '_');
                                result = result.Replace('(', '_');
                                result = result.Replace(')', '_');
                                result = result.Replace('.', '_');

                                listView1.Columns.Add(result, 70);
                            }
                        }
                    }


                    for (int i = 1; i <= 1; i++)
                    {
                        Excel.Range range = worksheet.get_Range("A" + i.ToString(), "M" + i.ToString());
                        System.Array myvalues = (System.Array)range.Cells.Value;
                        string[] strArray1 = ConvertToStringArray(myvalues);
                        //  int primaryKey = 1;

                        foreach (var strAr in strArray1)
                        {

                            if (strAr != "")
                            {
                                string result = strAr.Replace(' ', '_');
                                result = result.Replace('(', '_');
                                result = result.Replace(')', '_');
                                result = result.Replace('.', '_');
                                listView1.Columns.Add(result, 120);
                            }
                        }

                    }

                    for (int i = 8; i <= lastUsedRow; i++)
                    {
                        Excel.Range range = worksheet.get_Range("A" + i.ToString(), "M" + i.ToString());
                        System.Array myvalues = (System.Array)range.Cells.Value;
                        string[] strArray = ConvertToStringArray(myvalues);
                        ListViewItem itm;
                        itm = new ListViewItem(strArray);
                        listView1.Items.Add(itm);
                    }

                    // sreden prosek na klas
                    List<string> prosekOcenki = new List<string>();
                    for (int i = 8; i <= 27; i++)
                    {
                        Excel.Range range = worksheet.get_Range("C" + i.ToString(), "M" + i.ToString());
                        System.Array myvalues = (System.Array)range.Cells.Value;

                        string[] strArray = ConvertToStringArray(myvalues);

                        foreach (var vrednosti in strArray)
                        {
                            prosekOcenki.Add(vrednosti);
                        }


                    }

                    // MessageBox.Show(string.Join(Environment.NewLine, prosekOcenki));
                    double reshenie = SredenProsekNaOcenki(prosekOcenki);
                    //MessageBox.Show(reshenie.ToString());
                    prosekKlas = reshenie.ToString();
                    //sreden prosek na klas



                    //Prosek po ucenik
                    for (int i = 8; i <= lastUsedRow; i++)
                    {

                        Excel.Range range = worksheet.get_Range("B" + i.ToString(), "M" + i.ToString());
                        System.Array myvalues = (System.Array)range.Cells.Value;

                        string[] strArray = ConvertToStringArray(myvalues);
                        string imeNaUcenik = "";
                        List<string> prosekOcenkiUcenik = new List<string>();
                        int kolkuEdiniciIma = 0;
                        //MessageBox.Show(string.Join(Environment.NewLine, strArray));//prikazi vo poraka
                        foreach (var strAr in strArray)
                        {
                            double ocenki;
                            if (strAr != "")
                            {
                                bool daliEocenka = Double.TryParse(strAr, out ocenki);
                                if (daliEocenka)
                                {
                                    prosekOcenkiUcenik.Add(strAr);
                                    if(ocenki == 1)
                                    {
                       
                                        kolkuEdiniciIma ++;
                                    }
                                }
                                else
                                {
                                    imeNaUcenik = strAr;
                                }
                            }
        

                        }
                        if(kolkuEdiniciIma > 0)
                        {
                            string[] arrSlabiOcenki = new string[2];

                            arrSlabiOcenki[0] = imeNaUcenik.ToString();
                            arrSlabiOcenki[1] = kolkuEdiniciIma.ToString();

                            slabiOcenkiLista.Add(arrSlabiOcenki);
                           // MessageBox.Show(imeNaUcenik + " " + kolkuEdiniciIma.ToString());
                        }

                        double prosekNaUcenikot = SredenProsekNaOcenki(prosekOcenkiUcenik);

                        prosekUcenikIme.Add(imeNaUcenik.ToString());
                        prosekUcenikProsek.Add(prosekNaUcenikot.ToString());
                        prosekOcenkiUcenik.Clear();
                    }
                    //Prosek po ucenik

                    //prosek po predmet
                    List<string> prosek = new List<string>();
                    List<string> vrednostiDistribucija = new List<string>();//Distribucija na ocenki
                    List<string> prosekOtstapuvanja = new List<string>();//Otstapuvanje na ocenki
                    string imeNaPredmet = "";
                    double reshenieProsek = 0;
                    List<string> prosekPredmetiIme = new List<string>();

                    List<string> predmeti = new List<string>() { "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M" };
                    foreach (var p in predmeti)
                    {

                        for (int i = 1; i <= lastUsedRow; i++)
                        {
                            Excel.Range range = worksheet.get_Range(p + i.ToString());
                            if (range != null && range.Value2 != null)
                            {
                                string cellValue = range.Value2.ToString();
                                if (i == 1)
                                {


                                    if (cellValue != "")
                                    {
                                        imeNaPredmet = cellValue;
                                    }

                                }
                                else if (i > 7)
                                {
                                    prosek.Add(cellValue);
                                    vrednostiDistribucija.Add(cellValue);//Distribucija na ocenki
                                    prosekOtstapuvanja.Add(cellValue);//Otstapvanje na ocenki
                                }

                            }

                        }

                        reshenieProsek = SredenProsekNaOcenki(prosek);
                        prosekPredmetIme.Add(imeNaPredmet.ToString());
                        prosekPredmetProsek.Add(reshenieProsek.ToString());

                        //Distribucija ocenki
                        string[] arrDistribucija = new string[6];

                        arrDistribucija[0] = imeNaPredmet.ToString();

                        var distribucija = Distribucija(vrednostiDistribucija);
                        foreach (var d in distribucija)
                        {
                            if (d.Key == 1)
                            {
                                arrDistribucija[1] = d.Value.ToString();
                            }
                            else if (d.Key == 2)
                            {
                                arrDistribucija[2] = d.Value.ToString();
                            }
                            else if (d.Key == 3)
                            {
                                arrDistribucija[3] = d.Value.ToString();
                            }
                            else if (d.Key == 4)
                            {
                                arrDistribucija[4] = d.Value.ToString();
                            }
                            else if (d.Key == 5)
                            {
                                arrDistribucija[5] = d.Value.ToString();
                            }
                        }

                        distribucijaOcenkiLista.Add(arrDistribucija);
                        //distribucija ocenki

                        double otstapvanje, sredenProsek;
                        bool tryParseB = Double.TryParse(prosekKlas, out sredenProsek);
                        if (tryParseB)
                        {
                            // otstapvanje = Math.Abs((reshenieProsek - sredenProsek));
                            otstapvanje = reshenieProsek - sredenProsek;
                            string[] arrOtstapvanje = new string[2];

                            arrOtstapvanje[0] = imeNaPredmet.ToString();
                            arrOtstapvanje[1] = otstapvanje.ToString();

                            otstapvanjeOcenkiLista.Add(arrOtstapvanje);

                        }

                        reshenieProsek = 0;
                        prosek.Clear();
                        vrednostiDistribucija.Clear();
                        prosekOtstapuvanja.Clear();
                    }
                }
            }
            catch (System.Exception excpt) { MessageBox.Show("Imate greska pri otvaranje na excel" + excpt); }

        }


        private void btnSnimiPodatoci_Click(object sender, EventArgs e)
        {
            List<string> listView = new List<string>();
            listView.Add("Година_Клас");
            listView.Add("Клас");
            listView.Add("Тромесечие");
            listView.Add("Учебна_Година");
            //     MessageBox.Show(cbGodinaKlas.Text);
            foreach (ColumnHeader item in listView1.Columns)
            {
                listView.Add(item.Text);
            }
            if (listView.Count == 17)
            {
                tbImeNaTabela.Text = "PredmetiCelosni";

            }
            else if (listView.Count == 9)
            {
                tbImeNaTabela.Text = "PredmetiNecelosni";
            }
            if (tbImeNaTabela.Text != "" && listView1.Items.Count > 0)
            {
                if (cbGodinaKlas.Text != "Godina Klas" && cbKlas.Text != "Klas" && cbTromesecie.Text != "Tromesecie" && cbUcebnaGodina.Text != "Ucebna godina")
                {

                    try
                    {

                        SQLiteConnection sqlite_conn;
                        sqlite_conn = CreateConnection();
                        CreateTableA(sqlite_conn, listView, tbImeNaTabela.Text);

                        foreach (ListViewItem item in listView1.Items)
                        {
                            List<string> listViewValues = new List<string> { cbGodinaKlas.Text, cbKlas.Text, cbTromesecie.Text, cbUcebnaGodina.Text };
                            // MessageBox.Show(item.Text);
                            for (int i = 0; i < item.SubItems.Count; i++)
                            {
                                //  MessageBox.Show(item.SubItems[i].Text);
                                listViewValues.Add(item.SubItems[i].Text);

                            }
                            InsertRow(sqlite_conn, listView, listViewValues, tbImeNaTabela.Text);
                        }
                        MessageBox.Show("Uspesno gi vnesivte site podatoci vo baza");
                        listView1.Items.Clear();
                        listView1.Columns.Insert(0, "Година_Клас");
                        listView1.Columns.Insert(1, "Клас");
                        listView1.Columns.Insert(2, "Тромесечие");
                        listView1.Columns.Insert(3, "Учебна_Година");
                        var sqlite_datareader = ReadData(sqlite_conn, tbImeNaTabela.Text);

                        while (sqlite_datareader.Read())
                        {
                            string[] arr = new string[17];
                            ListViewItem itm;

                            arr[0] = sqlite_datareader.GetValue(0).ToString();
                            arr[1] = sqlite_datareader.GetValue(1).ToString();
                            arr[2] = sqlite_datareader.GetValue(2).ToString();
                            arr[3] = sqlite_datareader.GetValue(3).ToString();
                            arr[4] = sqlite_datareader.GetValue(4).ToString();
                            arr[5] = sqlite_datareader.GetValue(5).ToString();
                            arr[6] = sqlite_datareader.GetValue(6).ToString();
                            arr[7] = sqlite_datareader.GetValue(7).ToString();
                            arr[8] = sqlite_datareader.GetValue(8).ToString();
                            arr[9] = sqlite_datareader.GetValue(9).ToString();
                            arr[10] = sqlite_datareader.GetValue(10).ToString();
                            arr[11] = sqlite_datareader.GetValue(11).ToString();
                            arr[12] = sqlite_datareader.GetValue(12).ToString();
                            arr[13] = sqlite_datareader.GetValue(13).ToString();
                            arr[14] = sqlite_datareader.GetValue(14).ToString();
                            arr[15] = sqlite_datareader.GetValue(15).ToString();
                            arr[16] = sqlite_datareader.GetValue(16).ToString();

                            itm = new ListViewItem(arr);
                            listView1.Items.Add(itm);

                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ima problem so zapisuvanjeto vo LISTVIEW !!!");
                    }
                }
                else
                {
                    MessageBox.Show("ZADOLZITELNO IZBERETE gi site opcii za vnesuvanje: godina na klas, klas, tromesecie, ucebna godina");
                }

            }
            else
            {
                MessageBox.Show("Vnesete dadoteka vo listView !!!");
            }



        }

        private void btnPrezPodatoci_Click(object sender, EventArgs e)
        {
            //try
            //{

            //}catch { MessageBox.Show("Nemozat da se prikazat podatoci od bazata !"); }
        }

        private void cbGodinaKlas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnProsekKlas_Click(object sender, EventArgs e)
        {
            ModalessProsekKlas objModalessProsekKlas = new ModalessProsekKlas();
            objModalessProsekKlas.Show();
        }

        public double SredenProsekNaOcenki(List<string> prosekOcenki)
        {
            double o;
            double vkupnoOcenki = 0;
            double vrednostOcenki = 0;
            double prosek = 0;
            foreach (string ocenka in prosekOcenki)
            {
                vkupnoOcenki++;
                bool daliEbrojka = Double.TryParse(ocenka, out o);
                if (daliEbrojka)
                {
                    vrednostOcenki = vrednostOcenki + o;
                }
            }
            prosek = vrednostOcenki / vkupnoOcenki;
            return prosek;
        }

        public SortedDictionary<int, int> Distribucija(List<string> vrednostiOdRange)
        {
            int vrednost;
            SortedDictionary<int, int> distribucijaOcenki = new SortedDictionary<int, int>();
            for (int i = 0; i < vrednostiOdRange.Count; i++)
            {
                bool tryParse = Int32.TryParse(vrednostiOdRange[i], out vrednost);
                if (tryParse)
                {
                    if (!distribucijaOcenki.ContainsKey(vrednost))
                    {
                        distribucijaOcenki[vrednost] = 1;
                    }
                    else if (distribucijaOcenki.ContainsKey(vrednost))
                    {
                        distribucijaOcenki[vrednost] += 1;
                    }
                }

            }
            return distribucijaOcenki;
        }

        private void btnProsekUcenik_Click(object sender, EventArgs e)
        {
            ModalessProsekUcenik objModalessProsekUcenik = new ModalessProsekUcenik();
            objModalessProsekUcenik.Show();

        }

        private void btnProsekPredmet_Click(object sender, EventArgs e)
        {
            ModalessProsekPredmeti objModalessProsekPredmeti = new ModalessProsekPredmeti();
            objModalessProsekPredmeti.Show();
        }

        private void btnDistribucijaOtcenki_Click(object sender, EventArgs e)
        {
            ModalessDistribucijaOcenki objModalessDistribucijaOcenki = new ModalessDistribucijaOcenki();
            objModalessDistribucijaOcenki.Show();
        }

        private void btnOtstapuvanjePredmet_Click(object sender, EventArgs e)
        {
            ModalessOtstapuvanjePredmeti objModalessOtstapuvanjePredmeti = new ModalessOtstapuvanjePredmeti();
            objModalessOtstapuvanjePredmeti.Show();
        }

        private void btnUceniciSlabiOcenki_Click(object sender, EventArgs e)
        {
            ModalessSlabiOcenki objModalessSlabiOcenki = new ModalessSlabiOcenki();
            objModalessSlabiOcenki.Show();
        }
    }
}
