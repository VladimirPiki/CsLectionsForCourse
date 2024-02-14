using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using System.Drawing.Drawing2D;
using Microsoft.Office.Interop.Excel;


namespace Z62.UceniciPredmeti
{

    public partial class Form1 : Form
    {
        private Excel.Application ExcelObj = null;

        public Form1()
        {
            InitializeComponent();
            TreeViewInicijalizacija();

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            for (int i = 0; i < 13; i++)
            {
                listView1.Columns.Add("", 100);
            }

            listViewProsekPoPredmet.View = View.Details;
            listViewProsekPoPredmet.GridLines = true;
            listViewProsekPoPredmet.FullRowSelect = true;

            listViewProsekPoPredmet.Columns.Add("ime na predmet", 200);
            listViewProsekPoPredmet.Columns.Add("prosek po predmet", 200);


            listViewProsekPoUcenici.View = View.Details;
            listViewProsekPoUcenici.GridLines = true;
            listViewProsekPoUcenici.FullRowSelect = true;

            listViewProsekPoUcenici.Columns.Add("ime na ucenik", 200);
            listViewProsekPoUcenici.Columns.Add("prosek na ucenik", 200);

            listViewDistribucija.View = View.Details;
            listViewDistribucija.GridLines = true;
            listViewDistribucija.FullRowSelect = true;

            listViewDistribucija.Columns.Add("ime na predmet", 200);
            listViewDistribucija.Columns.Add("ocenka 1", 90);
            listViewDistribucija.Columns.Add("ocenka 2", 90);
            listViewDistribucija.Columns.Add("ocenka 3", 90);
            listViewDistribucija.Columns.Add("ocenka 4", 90);
            listViewDistribucija.Columns.Add("ocenka 5", 90);


            listViewOtstapvanje.View = View.Details;
            listViewOtstapvanje.GridLines = true;
            listViewOtstapvanje.FullRowSelect = true;

            listViewOtstapvanje.Columns.Add("ime na predmet", 200);
            listViewOtstapvanje.Columns.Add("otstapuvanje", 200);

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
        private void TreeViewInicijalizacija()
        {
            string lokacija = @"C:\temp\Z62. UceniciPredmeti";
            DirectoryInfo pateka = new DirectoryInfo(lokacija);

            TreeNode patekaNode = new TreeNode(pateka.Name);
            TreeViewRekurzija(patekaNode, pateka);
            treeView.Nodes.Add(patekaNode);
        }

        private void TreeViewRekurzija(TreeNode glavenNode, DirectoryInfo direktorium)
        {
            foreach (var dadoteka in direktorium.GetFiles())
            {
                TreeNode fileNode = new TreeNode(dadoteka.Name);
                glavenNode.Nodes.Add(fileNode);
            }

            foreach (var podDirektorium in direktorium.GetDirectories())
            {
                TreeNode podGlavenNode = new TreeNode(podDirektorium.Name);
                glavenNode.Nodes.Add(podGlavenNode);
                TreeViewRekurzija(podGlavenNode, podDirektorium);
            }
        }
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

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

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode != null)
            {
                try
                {
                    if (treeView.SelectedNode.FullPath != "")
                    {
                        var selektiranaNode = treeView.SelectedNode.FullPath;
                        var nodeFileName = "C:\\temp\\" + selektiranaNode;
                        if (File.Exists(nodeFileName))
                        {
                            //   var imetoNaDadoteka=Path.GetFileName(nodeFileName); 
                            if (Path.GetExtension(nodeFileName) == ".xls" || Path.GetExtension(nodeFileName) == ".xlsx")
                            {
                                //  MessageBox.Show(openFileDialog1.FileName);
                                // Here is the call to Open a Workbook in Excel   
                                // It uses most of the default values (except for the read-only which we set to true)  
                                Excel.Workbook theWorkbook = ExcelObj.Workbooks.Open(nodeFileName, 0, true, 5,
                                "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true);
                                // get the collection of sheets in the workbook  
                                Excel.Sheets sheets = theWorkbook.Worksheets;
                                // get the first and only worksheet from the collection of worksheets  
                                Excel.Worksheet worksheet = (Excel.Worksheet)sheets.get_Item(1);
                                // loop through 10 rows of the spreadsheet and place each row in the list view  


                                // Find the last real row
                                int lastUsedRow = 0;
                                lastUsedRow = worksheet.Cells.Find("*", System.Reflection.Missing.Value,
                                                               System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                                                               Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlPrevious,
                                                               false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;

                                for (int i = 1; i <= lastUsedRow; i++)
                                {
                                    Excel.Range range = worksheet.get_Range("A" + i.ToString(), "M" + i.ToString());
                                    System.Array myvalues = (System.Array)range.Cells.Value;
                                    string[] strArray = ConvertToStringArray(myvalues);
                                    if (i == 1)
                                    {
                                        //MessageBox.Show(string.Join(Environment.NewLine, strArray));//prikazi vo poraka
                                        foreach (var strAr in strArray)
                                        {
                                            if (strAr != "")
                                            {
                                                lbIminjaPredmeti.Items.Add(strAr);
                                            }
                                        }
                                    }
                                    listView1.Items.Add(new ListViewItem(strArray));
                                }

                                // sreden prosek na klas
                                List<string> prosekOcenki = new List<string>();
                                for (int i = 8; i <= 27; i++)
                                {
                                    Excel.Range range = worksheet.get_Range("C" + i.ToString(), "M" + i.ToString());
                                    System.Array myvalues = (System.Array)range.Cells.Value;

                                    string[] strArray = ConvertToStringArray(myvalues);
                                    if (i == 1)
                                    {
                                        //MessageBox.Show(string.Join(Environment.NewLine, strArray));//prikazi vo poraka
                                        foreach (var strAr in strArray)
                                        {
                                            if (strAr != "")
                                            {
                                                lbIminjaPredmeti.Items.Add(strAr);
                                            }
                                        }
                                    }
                                    foreach (var vrednosti in strArray)
                                    {
                                        prosekOcenki.Add(vrednosti);
                                    }


                                }

                                // MessageBox.Show(string.Join(Environment.NewLine, prosekOcenki));
                                double reshenie = SredenProsekNaOcenki(prosekOcenki);
                                //MessageBox.Show(reshenie.ToString());
                                tbSredenProsekKlas.Text = reshenie.ToString();
                                //sreden prosek na klas

                            }
                            else
                            {
                                MessageBox.Show("Dozvoleni se samo dadoteki so ekstenzija .xls ili .xlsx");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Dadoteka sto ja barate ne postoi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Izberete eksel dadoteka");
                    }

                }
                catch (System.Exception excpt)
                {
                    MessageBox.Show("Imate problem so izbiranjeto na dadotekata od treeview." + excpt);
                }

            }
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

        private void btnProcitaj_Click(object sender, EventArgs e)
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

                for (int i = 1; i <= lastUsedRow; i++)
                {
                    Excel.Range range = worksheet.get_Range("A" + i.ToString(), "M" + i.ToString());
                    System.Array myvalues = (System.Array)range.Cells.Value;
                    string[] strArray = ConvertToStringArray(myvalues);
                    MessageBox.Show(string.Join(Environment.NewLine, strArray));
                    //  listView1.Items.Add(new ListViewItem(strArray));
                }
            }

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

        //public double KolkuOtstapuvaProsekotPoPredemetOdProsekotNaKlasot(double a, double b)
        //{
        //    double c = 0;
        //    double d = 0, f = 0;
        //    d = Math.Abs((a - b));
        //    f = (a + b) / 2;
        //    c = (d / f) * 100;
        //    return c;
        //}



        private void btnSredenProsekKlas_Click(object sender, EventArgs e)
        {
            try
            {

                if (tbSredenProsekKlas.Text != "")
                {
                    MessageBox.Show(tbSredenProsekKlas.Text);
                }

            }
            catch
            {
                MessageBox.Show("Imate problem so vcituvanjeto na sredniot prosek na ucenicite");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnOtstapuvanja_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode != null)
            {
                try
                {
                    if (treeView.SelectedNode.FullPath != "")
                    {
                        var selektiranaNode = treeView.SelectedNode.FullPath;
                        var nodeFileName = "C:\\temp\\" + selektiranaNode;
                        if (File.Exists(nodeFileName))
                        {
                            //   var imetoNaDadoteka=Path.GetFileName(nodeFileName); 
                            if (Path.GetExtension(nodeFileName) == ".xls" || Path.GetExtension(nodeFileName) == ".xlsx")
                            {

                                Excel.Workbook theWorkbook = ExcelObj.Workbooks.Open(nodeFileName, 0, true, 5,
                                "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true);

                                Excel.Sheets sheets = theWorkbook.Worksheets;

                                Excel.Worksheet worksheet = (Excel.Worksheet)sheets.get_Item(1);
                                int lastUsedRow = 0;
                                lastUsedRow = worksheet.Cells.Find("*", System.Reflection.Missing.Value,
                                                               System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                                                               Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlPrevious,
                                                               false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;

                                //Kolku e otstapuva prosekot po predmet od prosek na klasot
                                List<string> prosekOtstapuvanja = new List<string>();
                                string imeNaPredmet = "";
                                double reshenieProsekOstapuvanje = 0;
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
                                                //MessageBox.Show(string.Join(Environment.NewLine, strArray));//prikazi vo poraka

                                                if (cellValue != "")
                                                {
                                                    imeNaPredmet = cellValue;
                                                }

                                                // break;   
                                            }
                                            else if (i > 7)
                                            {
                                                prosekOtstapuvanja.Add(cellValue);
                                            }

                                        }

                                    }

                                    reshenieProsekOstapuvanje = SredenProsekNaOcenki(prosekOtstapuvanja);
                                    //     MessageBox.Show(prosekOtstapuvanja.Count.ToString());
                                    double otstapvanje, sredenProsek;
                                    bool tryParseB = Double.TryParse(tbSredenProsekKlas.Text, out sredenProsek);
                                    if (tryParseB)
                                    {
                                            otstapvanje = Math.Abs((reshenieProsekOstapuvanje - sredenProsek));

                                        string[] arr = new string[2];
                                        ListViewItem itm;

                                        arr[0] = imeNaPredmet.ToString();
                                        arr[1] = otstapvanje.ToString();

                                        itm = new ListViewItem(arr);
                                        listViewOtstapvanje.Items.Add(itm);

                                        reshenieProsekOstapuvanje = 0;
                                        prosekOtstapuvanja.Clear();
                                    }
                               

               
                                }
                            }
                            else
                            {
                                MessageBox.Show("Dozvoleni se samo dadoteki so ekstenzija .xls ili .xlsx");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Dadoteka sto ja barate ne postoi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Izberete eksel dadoteka");
                    }

                }
                catch (System.Exception excpt)
                {
                    MessageBox.Show("Imate problem so otstapuvanjeto na prosekot na predmeti so sredniot prosek " +excpt);
                }

            }
        }

        private void btnProsekPoUcenik_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnDistribucija_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode != null)
            {
                try
                {
                    if (treeView.SelectedNode.FullPath != "")
                    {
                        var selektiranaNode = treeView.SelectedNode.FullPath;
                        var nodeFileName = "C:\\temp\\" + selektiranaNode;
                        if (File.Exists(nodeFileName))
                        {

                            if (Path.GetExtension(nodeFileName) == ".xls" || Path.GetExtension(nodeFileName) == ".xlsx")
                            {

                                Excel.Workbook theWorkbook = ExcelObj.Workbooks.Open(nodeFileName, 0, true, 5,
                                "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true);

                                Excel.Sheets sheets = theWorkbook.Worksheets;

                                Excel.Worksheet worksheet = (Excel.Worksheet)sheets.get_Item(1);
                                int lastUsedRow = 0;
                                lastUsedRow = worksheet.Cells.Find("*", System.Reflection.Missing.Value,
                                                               System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                                                               Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlPrevious,
                                                               false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;


                                List<string> vrednosti = new List<string>();
                                string imeNaPredmet = "";
                
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

                                                // break;   
                                            }
                                            else if (i > 7)
                                            {
                                                vrednosti.Add(cellValue);
                                            }

                                        }

                                    }

                                    string[] arrDistribucija = new string[6];
                                    ListViewItem itmrDistribucija;

                                    arrDistribucija[0] = imeNaPredmet.ToString();

                                    var distribucija = Distribucija(vrednosti);
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

                                    itmrDistribucija = new ListViewItem(arrDistribucija);
                                    listViewDistribucija.Items.Add(itmrDistribucija);
                                    vrednosti.Clear();
                                }

                            }
                            else
                            {
                                MessageBox.Show("Dozvoleni se samo dadoteki so ekstenzija .xls ili .xlsx");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Dadoteka sto ja barate ne postoi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Izberete eksel dadoteka");
                    }

                }
                catch (System.Exception excpt)
                {
                    MessageBox.Show("Imate problem so izbiranjeto na dadotekata od treeview." + excpt);
                }

            }
        }

        private void btnProsekPoPredmet_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode != null)
            {
                try
                {
                    if (treeView.SelectedNode.FullPath != "")
                    {
                        var selektiranaNode = treeView.SelectedNode.FullPath;
                        var nodeFileName = "C:\\temp\\" + selektiranaNode;
                        if (File.Exists(nodeFileName))
                        {
                      
                            if (Path.GetExtension(nodeFileName) == ".xls" || Path.GetExtension(nodeFileName) == ".xlsx")
                            {
    
                                Excel.Workbook theWorkbook = ExcelObj.Workbooks.Open(nodeFileName, 0, true, 5,
                                "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true);
                  
                                Excel.Sheets sheets = theWorkbook.Worksheets;
                 
                                Excel.Worksheet worksheet = (Excel.Worksheet)sheets.get_Item(1);

                                int lastUsedRow = 0;
                                lastUsedRow = worksheet.Cells.Find("*", System.Reflection.Missing.Value,
                                                               System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                                                               Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlPrevious,
                                                               false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;

                                List<string> prosek = new List<string>();
                                string imeNaPredmet = "";
                                double reshenieProsek = 0;
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
                                            }

                                        }

                                    }

                                    reshenieProsek = SredenProsekNaOcenki(prosek);


                                    string[] arr = new string[2];
                                    ListViewItem itm;

                                    arr[0] = imeNaPredmet.ToString();
                                    arr[1] = reshenieProsek.ToString();

                                    itm = new ListViewItem(arr);
                                    listViewProsekPoPredmet.Items.Add(itm);

                                    reshenieProsek = 0;
                                    prosek.Clear();
                                }
                    



                            }
                            else
                            {
                                MessageBox.Show("Dozvoleni se samo dadoteki so ekstenzija .xls ili .xlsx");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Dadoteka sto ja barate ne postoi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Izberete eksel dadoteka");
                    }

                }
                catch (System.Exception excpt)
                {
                    MessageBox.Show("Imate problem so izbiranjeto na dadotekata od treeview." + excpt);
                }

            }
        }

        private void btnProsekUcenik_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode != null)
            {
                try
                {
                    if (treeView.SelectedNode.FullPath != "")
                    {
                        var selektiranaNode = treeView.SelectedNode.FullPath;
                        var nodeFileName = "C:\\temp\\" + selektiranaNode;
                        if (File.Exists(nodeFileName))
                        {
                            //   var imetoNaDadoteka=Path.GetFileName(nodeFileName); 
                            if (Path.GetExtension(nodeFileName) == ".xls" || Path.GetExtension(nodeFileName) == ".xlsx")
                            {

                                Excel.Workbook theWorkbook = ExcelObj.Workbooks.Open(nodeFileName, 0, true, 5,
                                "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true);

                                Excel.Sheets sheets = theWorkbook.Worksheets;

                                Excel.Worksheet worksheet = (Excel.Worksheet)sheets.get_Item(1);

                                int lastUsedRow = 0;
                                lastUsedRow = worksheet.Cells.Find("*", System.Reflection.Missing.Value,
                                                               System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                                                               Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlPrevious,
                                                               false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;

                                //Prosek po ucenik

                                for (int i = 8; i <= lastUsedRow; i++)
                                {

                                    Excel.Range range = worksheet.get_Range("B" + i.ToString(), "M" + i.ToString());
                                    System.Array myvalues = (System.Array)range.Cells.Value;

                                    string[] strArray = ConvertToStringArray(myvalues);
                                    string imeNaUcenik = "";
                                    List<string> prosekOcenkiUcenik = new List<string>();

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
                                            }
                                            else
                                            {
                                                imeNaUcenik = strAr;
                                            }
                                        }

                                    }

                                    double prosekNaUcenikot = SredenProsekNaOcenki(prosekOcenkiUcenik);
                                    string[] arr = new string[2];
                                    ListViewItem itm;

                                    arr[0] = imeNaUcenik.ToString();
                                    arr[1] = prosekNaUcenikot.ToString();

                                    itm = new ListViewItem(arr);
                                    listViewProsekPoUcenici.Items.Add(itm);
                                    prosekOcenkiUcenik.Clear();
                                }
                                //Prosek po ucenik



                            }
                            else
                            {
                                MessageBox.Show("Dozvoleni se samo dadoteki so ekstenzija .xls ili .xlsx");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Dadoteka sto ja barate ne postoi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Izberete eksel dadoteka");
                    }

                }
                catch (System.Exception excpt)
                {
                    MessageBox.Show("Imate problem so izbiranjeto na dadotekata od treeview." + excpt);
                }

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
