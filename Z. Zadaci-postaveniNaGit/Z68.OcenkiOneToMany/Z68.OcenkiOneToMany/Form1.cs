using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Data.Common;
using System.Data.SQLite;
using static Z68.OcenkiOneToMany.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Z68.OcenkiOneToMany
{

    public partial class Form1 : Form
    {
        static public string prosekKlas;

        static public List<string> prosekUcenikIme = new List<string>();
        static public List<string> prosekUcenikProsek = new List<string>();

        static public List<string> prosekPredmetIme = new List<string>();
        static public List<string> prosekPredmetProsek = new List<string>();

        static public List<string[]> distribucijaOcenkiLista = new List<string[]>();
        static public List<string[]> otstapvanjeOcenkiLista = new List<string[]>();
        static public List<string[]> slabiOcenkiLista = new List<string[]>();

        private Excel.Application ExcelObj = null;
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbTromesecie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnProsekKlas_Click(object sender, EventArgs e)
        {
            ModalessProsekKlas objModalessProsekKlas = new ModalessProsekKlas();
            objModalessProsekKlas.Show();
        }

        private void btnProsekPredmet_Click(object sender, EventArgs e)
        {
            ModalessProsekPredmeti objModalessProsekPredmeti = new ModalessProsekPredmeti();
            objModalessProsekPredmeti.Show();
        }

        private void btnOtstapuvanjePredmet_Click(object sender, EventArgs e)
        {
            ModalessOtstapuvanjePredmeti objModalessOtstapuvanjePredmeti = new ModalessOtstapuvanjePredmeti();
            objModalessOtstapuvanjePredmeti.Show();
        }

        private void btnDistribucijaOtcenki_Click(object sender, EventArgs e)
        {
            ModalessDistribucijaOcenki objModalessDistribucijaOcenki = new ModalessDistribucijaOcenki();
            objModalessDistribucijaOcenki.Show();
        }

        private void btnUceniciSlabiOcenki_Click(object sender, EventArgs e)
        {
            ModalessSlabiOcenki objModalessSlabiOcenki = new ModalessSlabiOcenki();
            objModalessSlabiOcenki.Show();
        }

        private void btnPrezPodatoci_Click(object sender, EventArgs e)
        {
            Klasi objKlasi = new Klasi();
            listView1.Clear();
            listView1.Columns.Clear();
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

                    // Find the last real column
                    int lastUsedColumn = 0;
                    lastUsedColumn = worksheet.Cells.Find("*", System.Reflection.Missing.Value,
                                                     System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                                                     Excel.XlSearchOrder.xlByColumns, Excel.XlSearchDirection.xlPrevious,
                                                     false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Column;


                    string columnName = Klasi.ExcelColumnFromNumber(lastUsedColumn);


                    for (int i = 1; i <= 1; i++)
                    {
                        Excel.Range range = worksheet.get_Range("A" + i.ToString(), columnName + i.ToString());
                        System.Array myvalues = (System.Array)range.Cells.Value;
                        string[] strArray1 = objKlasi.ConvertToStringArray(myvalues);
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

                    for (int i = 2; i <= lastUsedRow; i++)
                    {
                        Excel.Range range = worksheet.get_Range("A" + i.ToString(), columnName + i.ToString());
                        System.Array myvalues = (System.Array)range.Cells.Value;
                        string[] strArray = objKlasi.ConvertToStringArray(myvalues);
                        ListViewItem itm;
                        itm = new ListViewItem(strArray);
                        listView1.Items.Add(itm);
                    }

                    // sreden prosek na klas
                    List<string> prosekOcenki = new List<string>();
                    for (int i = 2; i <= lastUsedRow; i++)
                    {
                        Excel.Range range = worksheet.get_Range("F" + i.ToString(), columnName + i.ToString());
                        System.Array myvalues = (System.Array)range.Cells.Value;

                        string[] strArray = objKlasi.ConvertToStringArray(myvalues);

                        foreach (var vrednosti in strArray)
                        {
                            prosekOcenki.Add(vrednosti);
                        }


                    }

                    // MessageBox.Show(string.Join(Environment.NewLine, prosekOcenki));
                    double reshenie = objKlasi.SredenProsekNaOcenki(prosekOcenki);
                    //MessageBox.Show(reshenie.ToString());
                    prosekKlas = reshenie.ToString();
                    //sreden prosek na klas

                    //Prosek po ucenik
                    for (int i = 2; i <= lastUsedRow; i++)
                    {

                        Excel.Range range = worksheet.get_Range("B" + i.ToString(), columnName + i.ToString());
                        System.Array myvalues = (System.Array)range.Cells.Value;

                        string[] strArray = objKlasi.ConvertToStringArray(myvalues);
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
                                    if (ocenki == 1)
                                    {
                                        kolkuEdiniciIma++;
                                    }
                                }
                                else
                                {
                                    imeNaUcenik += " " + strAr;
                                }
                            }


                        }
                        if (kolkuEdiniciIma > 0)
                        {
                            string[] arrSlabiOcenki = new string[2];

                            arrSlabiOcenki[0] = imeNaUcenik.ToString();
                            arrSlabiOcenki[1] = kolkuEdiniciIma.ToString();

                            slabiOcenkiLista.Add(arrSlabiOcenki);
                            // MessageBox.Show(imeNaUcenik + " " + kolkuEdiniciIma.ToString());
                        }

                        double prosekNaUcenikot = objKlasi.SredenProsekNaOcenki(prosekOcenkiUcenik);

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

                    List<string> predmeti = new List<string>() { "F", "G", "H", "I", "J", "K", "L", "M", "N", "O" };
                    foreach (var p in predmeti)
                    {
                        if (p[0] <= columnName[0])
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
                                    else
                                    {
                                        prosek.Add(cellValue);
                                        vrednostiDistribucija.Add(cellValue);//Distribucija na ocenki
                                        prosekOtstapuvanja.Add(cellValue);//Otstapvanje na ocenki
                                    }

                                }

                            }

                            reshenieProsek = objKlasi.SredenProsekNaOcenki(prosek);
                            prosekPredmetIme.Add(imeNaPredmet.ToString());
                            prosekPredmetProsek.Add(reshenieProsek.ToString());

                            //Distribucija ocenki
                            string[] arrDistribucija = new string[6];

                            arrDistribucija[0] = imeNaPredmet.ToString();

                            var distribucija = objKlasi.Distribucija(vrednostiDistribucija);
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
            }
            catch (System.Exception excpt) { MessageBox.Show("Imate greska pri otvaranje na excel" + excpt); }
        }

        private void btnNapraviExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.Items.Count > 0)
                {
                    using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Dadoteka|*.xlsx", ValidateNames = true })
                    {
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            Workbook wb = ExcelObj.Workbooks.Add(XlSheetType.xlWorksheet);
                            Worksheet ws = (Worksheet)ExcelObj.ActiveSheet;
                            ExcelObj.Visible = true;
                            int a = 1;
                            int k = 1;
                            int i = 2;
                  
                            foreach (ColumnHeader header in listView1.Columns)
                            {
                                //  MessageBox.Show(header.Text);
                                ws.Cells[a, k] = header.Text;
                                k++;
                            }
                            foreach (ListViewItem item in listView1.Items)
                            {
                                int v = 1;
                                for (int j = 0; j < item.SubItems.Count; j++)
                                {
                                    ws.Cells[i, v] = item.SubItems[j].Text;
                                    v++;
                                }
                                i++;
                                v = 0;
                            }

                            // wb.SaveAs(sfd.FileName,XlFileFormat.xlWorkbookDefault,Type.Missing,Type.Missing,true,false,XlSaveAsAccessMode.xlNoChange,XlSaveConflictResolution.xlLocalSessionChanges);
                            wb.SaveAs(sfd.FileName);
                            tbAttachemt.Text = sfd.FileName;

                            ExcelObj.Quit();
                            MessageBox.Show("Uspeshno e exportirana dadotekata");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ve molam vneste podatoci vo listview");
                }

            }
            catch
            {
                MessageBox.Show("Ima problem so exportiranjeto na excel dadotekata");
            }
        }

        private void btnIspratiMeil_Click(object sender, EventArgs e)
        {
            ModalMeil modalMeil = new ModalMeil();
            modalMeil.ShowDialog(); 
        }

        private void btnSnimiPodatoci_Click(object sender, EventArgs e)
        {
            List<string> listView = new List<string>();
            listView.Add("Клас");
            listView.Add("Смер");
            listView.Add("Тромесечие");
            listView.Add("Учебна_Година");
            //     MessageBox.Show(cbGodinaKlas.Text);
            List<string> ucenicivrednostiListview = new List<string>();
            foreach (ColumnHeader item in listView1.Columns)
            {
                if (item.Text == "EMB" || item.Text == "Презиме" || item.Text == "Татково_име" || item.Text == "Име" || item.Text == "Место")
                {
                    ucenicivrednostiListview.Add(item.Text);
                }
                else
                {
                    listView.Add(item.Text);
                }

            }
            listView.Add("UceniciEMB");//Maticen kolona

            if (listView1.Items.Count > 0)
            {
                if (cbKlas.Text != "Изберете клас" && cbSmer.Text != "Изберете смер" && cbTromesecie.Text != "Изберете тромесечие" && cbUcebnaGodina.Text != "Изберете учебна година")
                {

                    try
                    {

                        string connectionString = "Data Source=mydatabase.db;Version=3;";
                        SQLiteManager objSql = new SQLiteManager(connectionString);
                        objSql.CreateTables();

                        foreach (ListViewItem item in listView1.Items)
                        {
                            List<string> listViewValues = new List<string> { cbKlas.Text, cbSmer.Text, cbTromesecie.Text, cbUcebnaGodina.Text };
                            List<string> listViewValuesUcenici = new List<string>();
                            string maticen = "";

                            for (int i = 0; i < item.SubItems.Count; i++)
                            {
                                if (i > 4)
                                {
                                    listViewValues.Add(item.SubItems[i].Text);
                                }
                                else
                                {
                                    listViewValuesUcenici.Add(item.SubItems[i].Text);
                                    if (i == 0)
                                    {
                                        maticen = item.SubItems[i].Text;
                                    }
                                }
                            }
                            listViewValues.Add(maticen);


                            objSql.InsertRow(listView, listViewValues, "Ocenki");
                            objSql.InsertRow(ucenicivrednostiListview, listViewValuesUcenici, "Ucenici");
                        }
                        MessageBox.Show("Uspesno gi vnesivte site podatoci vo baza");

                        listView1.Items.Clear();
                        listView1.Columns.Clear();

                        listView1.Columns.Add("EMB", 40);
                        listView1.Columns.Add("Презиме", 40);
                        listView1.Columns.Add("Татково_име", 40);
                        listView1.Columns.Add("Име", 40);
                        listView1.Columns.Add("Место", 40);
                        listView1.Columns.Add("ID", 40);
                        listView1.Columns.Add("Клас", 40);
                        listView1.Columns.Add("Смер", 40);
                        listView1.Columns.Add("Тромесечие", 40);
                        listView1.Columns.Add("Учебна_Година", 40);
                        listView1.Columns.Add("Македонски_јазик", 40);
                        listView1.Columns.Add("Математика", 40);
                        listView1.Columns.Add("Англиски_јазик", 40);
                        listView1.Columns.Add("Програмирање", 40);
                        listView1.Columns.Add("Физика", 40);
                        listView1.Columns.Add("Автоматика", 40);
                        listView1.Columns.Add("Објектно_ориентирано_програмирање", 40);
                        listView1.Columns.Add("Музика", 40);
                        listView1.Columns.Add("Изборен", 40);
                        listView1.Columns.Add("Практична_настава", 40);
                        listView1.Columns.Add("Статистика", 40); ;
                        listView1.Columns.Add("UceniciEMB", 40);


                        var sqlite_datareader = objSql.SelectFrom("Ucenici INNER JOIN Ocenki ON Ucenici.EMB = Ocenki.UceniciEMB");

                        while (sqlite_datareader.Read())
                        {
                            string[] arr = new string[22];
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
                            arr[17] = sqlite_datareader.GetValue(17).ToString();
                            arr[18] = sqlite_datareader.GetValue(18).ToString();
                            arr[19] = sqlite_datareader.GetValue(19).ToString();
                            arr[20] = sqlite_datareader.GetValue(20).ToString();
                            arr[21] = sqlite_datareader.GetInt64(21).ToString();

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
                    MessageBox.Show("ZADOLZITELNO IZBERETE gi site opcii za vnesuvanje: klas, smer, tromesecie, ucebna godina");
                }

            }
            else
            {
                MessageBox.Show("Vnesete dadoteka vo listView !!!");
            }

        }

        private void btnPrezemiPodatoci_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> koloni = new List<string>();
                List<string> vrednosti = new List<string>();

                if (tbMaticenBr.Text != "")
                {
                    koloni.Add("EMB=");
                    vrednosti.Add(tbMaticenBr.Text);
                }
                if (cbKlas.Text != "Изберете клас")
                {
                    koloni.Add("Клас=");
                    vrednosti.Add(cbKlas.Text);
                }
                if (cbSmer.Text != "Изберете смер")
                {
                    koloni.Add("Смер=");
                    vrednosti.Add(cbSmer.Text);
                }
                if (cbTromesecie.Text != "Изберете тромесечие")
                {
                    koloni.Add("Тромесечие=");
                    vrednosti.Add(cbTromesecie.Text);
                }
                if (cbUcebnaGodina.Text != "Изберете учебна година")
                {

                    koloni.Add("Учебна_Година=");
                    vrednosti.Add(cbUcebnaGodina.Text);
                }


                string where = "Ucenici INNER JOIN Ocenki ON Ucenici.EMB = Ocenki.UceniciEMB WHERE ";
                for (int i = 0; i < vrednosti.Count; i++)
                {

                    if (i < vrednosti.Count - 1)
                    {
                        where = where + koloni[i] + "'" + vrednosti[i] + "'" + " AND ";

                    }
                    else
                    {
                        where = where + koloni[i] + "'" + vrednosti[i] + "'";
                    }
                }
                richTextBox1.Text = where;

                listView1.Items.Clear();
                listView1.Columns.Clear();

                listView1.Columns.Add("EMB", 40);
                listView1.Columns.Add("Презиме", 40);
                listView1.Columns.Add("Татково_име", 40);
                listView1.Columns.Add("Име", 40);
                listView1.Columns.Add("Место", 40);
                listView1.Columns.Add("ID", 40);
                listView1.Columns.Add("Клас", 40);
                listView1.Columns.Add("Смер", 40);
                listView1.Columns.Add("Тромесечие", 40);
                listView1.Columns.Add("Учебна_Година", 40);
                listView1.Columns.Add("Македонски_јазик", 40);
                listView1.Columns.Add("Математика", 40);
                listView1.Columns.Add("Англиски_јазик", 40);
                listView1.Columns.Add("Програмирање", 40);
                listView1.Columns.Add("Физика", 40);
                listView1.Columns.Add("Автоматика", 40);
                listView1.Columns.Add("Објектно_ориентирано_програмирање", 40);
                listView1.Columns.Add("Музика", 40);
                listView1.Columns.Add("Изборен", 40);
                listView1.Columns.Add("Практична_настава", 40);
                listView1.Columns.Add("Статистика", 40); ;
                listView1.Columns.Add("UceniciEMB", 40);

                if(vrednosti.Count > 0 && koloni.Count > 0)
                {
                    string connectionString = "Data Source=mydatabase.db;Version=3;";
                    SQLiteManager objSql = new SQLiteManager(connectionString);
                    var sqlite_datareader = objSql.SelectFrom(where);

                    while (sqlite_datareader.Read())
                    {
                        string[] arr = new string[22];
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
                        arr[17] = sqlite_datareader.GetValue(17).ToString();
                        arr[18] = sqlite_datareader.GetValue(18).ToString();
                        arr[19] = sqlite_datareader.GetValue(19).ToString();
                        arr[20] = sqlite_datareader.GetValue(20).ToString();
                        arr[21] = sqlite_datareader.GetInt64(21).ToString();

                        itm = new ListViewItem(arr);
                        listView1.Items.Add(itm);

                    }
                }
                else
                {
                    MessageBox.Show("Ve molam vnesete prebaruvanje !!!");
                }
               
            }
            catch (Exception expt)
            {
                MessageBox.Show("Ima problem so prikazvuvanjeto na podatoicte " + expt);
            }

        }

        private void btnProsekUcenik_Click(object sender, EventArgs e)
        {
            ModalessProsekUcenik objModalessProsekUcenik = new ModalessProsekUcenik();
            objModalessProsekUcenik.Show();
        }


    }
}
