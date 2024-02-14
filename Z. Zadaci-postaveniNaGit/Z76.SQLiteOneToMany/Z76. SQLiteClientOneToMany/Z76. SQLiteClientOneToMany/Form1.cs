using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace Z76.SQLiteClientOneToMany
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

        //Za excel 
        public void ThreadProcExcel()
        {
            TcpListener server = null;
            try
            {
                // Set the IP address and port number for the server
                IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
                int port = 1234;
                System.Threading.Thread.Sleep(1000);

                // Create a TcpListener to listen for incoming connections
                server = new TcpListener(ipAddress, port);

                // Start listening for client requests
                server.Start();

                //MessageBox.ShowLine("Server is waiting for connections...");

                while (true)
                {
                    // Accept a client connection
                    TcpClient client = server.AcceptTcpClient();
                    // MessageBox.ShowLine("Client connected!");

                    // Get the network stream for reading
                    NetworkStream stream = client.GetStream();

                    // Receive the file name and create a file stream to save the Excel file
                    byte[] fileNameData = new byte[1024];
                    int fileNameBytesRead = stream.Read(fileNameData, 0, fileNameData.Length);
                    string fileName = Encoding.ASCII.GetString(fileNameData, 0, fileNameBytesRead);
                    fileName = Path.GetFileName(fileName);

                    FileStream fileStream = File.Create(fileName);

                    // Receive and save the Excel file data
                    byte[] buffer = new byte[1024];
                    int bytesRead;
                    while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        fileStream.Write(buffer, 0, bytesRead);
                    }

                 //  MessageBox.Show($"Excel file '{fileName}' received and saved.");

                    // Close the client connection and file stream
                    fileStream.Close();
                    client.Close();

                    CreateListViewFromServer(fileName);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: ThreadProcExcel" + e.Message);
            }
            finally
            {
                // Stop listening for incoming connections
                server.Stop();
            }
        }
        public Form1()
        {
            InitializeComponent();

            //thread za Excel file
            Thread threadExcel = new Thread(t =>
            {
                ThreadProcExcel();
            })
            {
                IsBackground = true
            };
            threadExcel.Start();

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
                            tbPatekaZaBaza.Text = sfd.FileName;

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

        private void btnProsekKlas_Click(object sender, EventArgs e)
        {
            ModalessProsekKlas objModalessProsekKlas = new ModalessProsekKlas();
            objModalessProsekKlas.Show();
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

        private void btnSnimiPodatoci_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                if (cbKlas.Text != "Изберете клас" && cbSmer.Text != "Изберете смер" && cbTromesecie.Text != "Изберете тромесечие" && cbUcebnaGodina.Text != "Изберете учебна година")
                {

                    listView1.Columns.Add("Клас");
                    listView1.Columns.Add("Смер");
                    listView1.Columns.Add("Тромесечие");
                    listView1.Columns.Add("Учебна_Година");

                    foreach (ListViewItem item in listView1.Items)
                    {
                        item.SubItems.Add(cbKlas.Text);
                        item.SubItems.Add(cbSmer.Text);
                        item.SubItems.Add(cbTromesecie.Text);
                        item.SubItems.Add(cbUcebnaGodina.Text);
                    }

                    try
                    {
                        string celaPateka = "";
                        using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Dadoteka|*.xlsx", ValidateNames = true })
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

                            string lokacijaVoClientDebug = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                            celaPateka = Path.Combine(lokacijaVoClientDebug, "podatociZaVoBaza.xlsx");

                            if (File.Exists(celaPateka))
                            {
                                File.Delete(celaPateka);

                            }

                            // wb.SaveAs(sfd.FileName,XlFileFormat.xlWorkbookDefault,Type.Missing,Type.Missing,true,false,XlSaveAsAccessMode.xlNoChange,XlSaveConflictResolution.xlLocalSessionChanges);
                            wb.SaveAs(celaPateka);
                            tbPatekaZaBaza.Text = celaPateka;

                            ExcelObj.Quit();
                            // MessageBox.Show("USPESNO E SNIMEN EXCEL");
                        }
                        System.Threading.Thread.Sleep(1000);

                        //    if (tbPatekaZaBaza.Text != "")
                        if (celaPateka != "")
                        {

                            // Set the server IP address and port number
                            string serverIp = "127.0.0.1";
                            int serverPort = 1027;
                            System.Threading.Thread.Sleep(1000);

                            // Create a TcpClient to connect to the server
                            TcpClient client = new TcpClient(serverIp, serverPort);
                            //MessageBox.Show("KLIENTOT E KONEKTIRAN !!!");

                            // Get the network stream for reading and writing
                            NetworkStream stream = client.GetStream();

                            // Specify the Excel file to send

                             string imeNaDadoteka = Path.GetFileName(celaPateka);
                            string filePath = imeNaDadoteka;
                            //  string filePath = patekaZaPustanjeDoServer;
                           // string filePath = "podatociZaVoBaza.xlsx";

                             // Send the file name to the server
                             byte[] fileNameData = Encoding.ASCII.GetBytes(Path.GetFileName(filePath));
                            stream.Write(fileNameData, 0, fileNameData.Length);

                            // Send the Excel file data to the server
                            byte[] buffer = new byte[1024];
                            int bytesRead;
                            using (FileStream fileStream = File.OpenRead(filePath))
                            {
                                while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                                {
                                    stream.Write(buffer, 0, bytesRead);
                                }
                            }

                        //    MessageBox.Show("EKSELOT E USPESHNO ISPRATEN");

                            // Close the client connection
                            client.Close();
                            tbPatekaZaBaza.Clear();
                        }

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Ima problem so snimanjeto vo baza    "+ ex);
                    }

                   

                }
                else
                {
                    MessageBox.Show("ZADOLZITELNO IZBERETE gi site opcii za vnesuvanje: klas, smer, tromesecie, ucebna godina");
                }
            }
            else
            {
                MessageBox.Show("Ve molam vneste podatoci vo listview");
            }
            }

        /*       static void CreateListViewFromServer(string fileName)
               {
                   try
                   {
                       Form1 form = new Form1();
                       form.listView1.Columns.Clear();
                       form.listView1.Items.Clear();

                       FileInfo excelFile = new FileInfo(fileName);
                       using (var package = new ExcelPackage(excelFile))
                       {
                           var worksheet = package.Workbook.Worksheets[0];
                           int rowCount = worksheet.Dimension.Rows;
                           int colCount = worksheet.Dimension.Columns;

                         //  MessageBox.Show($"Pogledete ja sodrzinata od excel dadotekata vo listview '{fileName}'");

                           for (int row = 1; row < 2; row++)
                           {
                               for (int col = 1; col <= colCount; col++)
                               {
                                   if (worksheet.Cells[row, col].Text != "")
                                   {
                                       string result = worksheet.Cells[row, col].Text.Replace(' ', '_');
                                       result = result.Replace('(', '_');
                                       result = result.Replace(')', '_');
                                       result = result.Replace('.', '_');

                                       form.listView1.Columns.Add(result, 120);
                                   }

                               }
                           }

                           for (int row = 2; row <= rowCount; row++)
                           {
                               ListViewItem itm = new ListViewItem();
                               for (int col = 1; col <= colCount; col++)
                               {
                                   string cellText = worksheet.Cells[row, col].Text;
                                   if (col == 1)
                                   {
                                       itm.Text = cellText;
                                   }
                                   else
                                   {
                                       itm.SubItems.Add(cellText);
                                   }
                               }
                               if (itm.SubItems.Count > 0)
                               {
                                   form.listView1.Items.Add(itm);
                               }
                           }

                       }
                   }
                   catch (Exception ex)
                   {
                       MessageBox.Show("Ima problem so Listview !!! " + ex);
                   }
               }
        */


        public void CreateListViewFromServer(string fileName)
        {
            try
            {
                Klasi objKlasi = new Klasi();   
                FileInfo excelFile = new FileInfo(fileName);

                Excel.Workbook theWorkbook = ExcelObj.Workbooks.Open(excelFile.FullName, 0, true, 5,
                "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true);

                Excel.Sheets sheets = theWorkbook.Worksheets;

                Excel.Worksheet worksheet = (Excel.Worksheet)sheets.get_Item(1);


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
                listView1.Columns.Clear();
                listView1.Items.Clear();

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
                            listView1.Invoke((MethodInvoker)delegate {
                                listView1.Columns.Add(result, 80);
                            });
                        }
                    }

                }

                for (int i = 2; i <= lastUsedRow; i++)
                {
                    Excel.Range range = worksheet.get_Range("A" + i.ToString(), columnName + i.ToString());
                    System.Array myvalues = (System.Array)range.Cells.Value;
                    string[] strArray = objKlasi.ConvertToStringArray(myvalues);

                    listView1.Invoke((MethodInvoker)delegate {
                        ListViewItem itm;
                        itm = new ListViewItem(strArray);
                        listView1.Items.Add(itm);
                    });
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ima problem so Listview !!! " + ex);
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

                if (vrednosti.Count > 0 && koloni.Count > 0)
                {
                    try
                    {
                        // Set the server IP address and port number
                        string serverIp = "localhost";
                        int serverPort = 8080;

                        // Create a TcpClient to connect to the server
                        TcpClient client = new TcpClient(serverIp, serverPort);
                        Console.WriteLine("Connected to server.");

                        // Get the network stream for reading and writing
                        NetworkStream stream = client.GetStream();

                        // Send a message to the server
                        string message = where;
                        //   byte[] data = Encoding.ASCII.GetBytes(message);
                        byte[] data = Encoding.UTF8.GetBytes(message);// KIRILICA UTF8
                        stream.Write(data, 0, data.Length);

                        // Close the client connection
                        client.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Ima problem so prebaruvanjeto !!!");
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

        private void tbPatekaZaBaza_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();

        }
    }
}
