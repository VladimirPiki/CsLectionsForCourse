using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using Excel = Microsoft.Office.Interop.Excel;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using Outlook = Microsoft.Office.Interop.Outlook;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Z64.LicnostiPodatoci
{
    public partial class Form1 : Form
    {
        private Excel.Application ExcelObj = null;
        private Outlook.Application OutlookObj = null;
        public Form1()
        {
            InitializeComponent();

            listView1.View = System.Windows.Forms.View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("maticen", 100);
            listView1.Columns.Add("ime", 100);
            listView1.Columns.Add("tatkovo ime", 100);
            listView1.Columns.Add("prezime", 100);
            listView1.Columns.Add("datum na ragjanje", 100);
            listView1.Columns.Add("adresa", 100);
            listView1.Columns.Add("mesto na ziveenje", 100);
            listView1.Columns.Add("klas", 100);
            listView1.Columns.Add("ucebna godina", 100);

            Database objDatabase = new Database();
            string pateka = objDatabase.proveriDaliImaKonekcija();
            if (!File.Exists(pateka))
            {
                objDatabase.KreirajTabela();
            }

            ExcelObj = new Excel.Application();

            if (ExcelObj == null)
            {
                MessageBox.Show("ERROR: EXCEL couldn't be started!");
                System.Windows.Forms.Application.Exit();
            }

            ExcelObj.Visible = true;
        }
        private void btnBaza_Click(object sender, EventArgs e)
        {

            try
            {

                if (tbMaticenBr.Text != "" && tbIme.Text != "" && tbTatkovoIme.Text != "" && tbPrezime.Text != "" && tbAdresa.Text != "" && tbMestoZiveenje.Text != "" && cbKlas.Text != "" && cbGodina.Text != "")
                {
                    if (tbMaticenBr.Text.Length == 13)
                    {
                        long maticen;
                        bool parsirajMaticen = Int64.TryParse(tbMaticenBr.Text, out maticen);
                        if (parsirajMaticen)
                        {

                            Licnost objLicnost = new Licnost();
                            objLicnost.MaticenBroj = maticen;
                            objLicnost.Ime = tbIme.Text;
                            objLicnost.TatkovoIme = tbTatkovoIme.Text;
                            objLicnost.Prezime = tbPrezime.Text;
                            objLicnost.Datum = dtDatumRag.Value;
                            objLicnost.Adresa = tbAdresa.Text;
                            objLicnost.Mesto = tbMestoZiveenje.Text;
                            objLicnost.Klas = cbKlas.Text;
                            objLicnost.GodinaUcebna = cbGodina.Text;

                            Database objDatabase = new Database();
                            objDatabase.VnesiVoBaza(maticen, objLicnost.Ime, objLicnost.TatkovoIme, objLicnost.Prezime, objLicnost.Datum, objLicnost.Adresa, objLicnost.Mesto, objLicnost.Klas, objLicnost.GodinaUcebna);

                            //Database objDB = new Database();
                            //LicnostDao objLicnost = new LicnostDao(objDB);

                            //objLicnost.MaticenBroj = maticen;
                            //objLicnost.Ime = tbIme.Text;
                            //objLicnost.TatkovoIme = tbTatkovoIme.Text;
                            //objLicnost.Prezime = tbPrezime.Text;
                            //objLicnost.Datum = dtDatumRag.Value;
                            //objLicnost.Adresa = tbAdresa.Text;
                            //objLicnost.Mesto = tbMestoZiveenje.Text;
                            //objLicnost.Klas = cbKlas.Text;
                            //objLicnost.GodinaUcebna = cbGodina.Text;

                            //objLicnost.VnesiLicnost();

                            var sqlite_datareader = objDatabase.PrikaziGiSite();
                            listView1.Items.Clear();
                            while (sqlite_datareader.Read())
                            {

                                string[] arr = new string[9];
                                ListViewItem itm;

                                arr[0] = sqlite_datareader.GetInt64(0).ToString();
                                arr[1] = sqlite_datareader.GetValue(1).ToString();
                                arr[2] = sqlite_datareader.GetValue(2).ToString();
                                arr[3] = sqlite_datareader.GetValue(3).ToString();
                                arr[4] = sqlite_datareader.GetValue(4).ToString();
                                arr[5] = sqlite_datareader.GetValue(5).ToString();
                                arr[6] = sqlite_datareader.GetValue(6).ToString();
                                arr[7] = sqlite_datareader.GetValue(7).ToString();
                                arr[8] = sqlite_datareader.GetValue(8).ToString();

                                itm = new ListViewItem(arr);
                                listView1.Items.Add(itm);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Vo poleto dozvoleni se samo brojki");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Vnesete ispraven maticen broj od 13 cifri !!!");
                    }

                }
                else
                {
                    MessageBox.Show("Site polinja se zadolzitelni");
                }
            }
            catch { MessageBox.Show("Ima problem so vnesuvanjeto vo baza !"); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbKlas_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnVnesiPodatoci_Click(object sender, EventArgs e)
        {
            try {
                Database objDatabase = new Database();

                var sqlite_datareader = objDatabase.PrikaziGiSite();
                listView1.Items.Clear();
                while (sqlite_datareader.Read())
                {

                    string[] arr = new string[9];
                    ListViewItem itm;

                    arr[0] = sqlite_datareader.GetInt64(0).ToString();
                    arr[1] = sqlite_datareader.GetValue(1).ToString();
                    arr[2] = sqlite_datareader.GetValue(2).ToString();
                    arr[3] = sqlite_datareader.GetValue(3).ToString();
                    arr[4] = sqlite_datareader.GetValue(4).ToString();
                    arr[5] = sqlite_datareader.GetValue(5).ToString();
                    arr[6] = sqlite_datareader.GetValue(6).ToString();
                    arr[7] = sqlite_datareader.GetValue(7).ToString();
                    arr[8] = sqlite_datareader.GetValue(8).ToString();

                    itm = new ListViewItem(arr);
                    listView1.Items.Add(itm);

                }
            } catch {
                MessageBox.Show("Ima problem so vnesuvanjeto vo listview !");
            }
        }

        private void dodajOdExcelBtn_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.FileName = "*.xls"; if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                 
                    Excel.Workbook theWorkbook = ExcelObj.Workbooks.Open(openFileDialog1.FileName, 0, true, 5,
                    "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true);

                    Excel.Sheets sheets = theWorkbook.Worksheets;

                    Excel.Worksheet worksheet = (Excel.Worksheet)sheets.get_Item(1);


                    int lastUsedRow = 0;
                    lastUsedRow = worksheet.Cells.Find("*", System.Reflection.Missing.Value,
                                                   System.Reflection.Missing.Value, System.Reflection.Missing.Value,
                                                   Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlPrevious,
                                                   false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;



                    for (int i = 2; i <= lastUsedRow; i++)
                    {
                        Excel.Range range = worksheet.get_Range("A" + i.ToString(), "I" + i.ToString());
                        System.Array myvalues = (System.Array)range.Cells.Value;
                        string[] strArray = ConvertToStringArray(myvalues);

                        if (strArray[0].Length == 13)
                        {
                            long maticen;
                            bool parsirajMaticen = Int64.TryParse(strArray[0], out maticen);
                            if (parsirajMaticen)
                            {

                                Licnost objLicnost = new Licnost();
                                objLicnost.MaticenBroj = maticen;
                                objLicnost.Ime = strArray[1];
                                objLicnost.TatkovoIme = strArray[2];
                                objLicnost.Prezime = strArray[3];
                                DateTime dateTime = DateTime.Parse(strArray[4]);
                                objLicnost.Datum = dateTime;
                                objLicnost.Adresa = strArray[5];
                                objLicnost.Mesto = strArray[6];
                                objLicnost.Klas = strArray[7];
                                objLicnost.GodinaUcebna = strArray[8];

                                Database objDatabase = new Database();
                                objDatabase.VnesiVoBaza(maticen, objLicnost.Ime, objLicnost.TatkovoIme, objLicnost.Prezime, objLicnost.Datum, objLicnost.Adresa, objLicnost.Mesto, objLicnost.Klas, objLicnost.GodinaUcebna);

                                var sqlite_datareader = objDatabase.PrikaziGiSite();
                                listView1.Items.Clear();
                                while (sqlite_datareader.Read())
                                {

                                    string[] arr = new string[9];
                                    ListViewItem itm;

                                    arr[0] = sqlite_datareader.GetInt64(0).ToString();
                                    arr[1] = sqlite_datareader.GetValue(1).ToString();
                                    arr[2] = sqlite_datareader.GetValue(2).ToString();
                                    arr[3] = sqlite_datareader.GetValue(3).ToString();
                                    arr[4] = sqlite_datareader.GetValue(4).ToString();
                                    arr[5] = sqlite_datareader.GetValue(5).ToString();
                                    arr[6] = sqlite_datareader.GetValue(6).ToString();
                                    arr[7] = sqlite_datareader.GetValue(7).ToString();
                                    arr[8] = sqlite_datareader.GetValue(8).ToString();

                                    itm = new ListViewItem(arr);
                                    listView1.Items.Add(itm);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Vo poleto dozvoleni se samo brojki");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Vnesete ispraven maticen broj od 13 cifri !!!");
                        }

                    }
                }
            }
            catch (System.Exception excpt) { MessageBox.Show("Imate greska pri otvaranje na excel" + excpt); }

        }

        private void btnBarajPodatoci_Click(object sender, EventArgs e)
        {
            if (rbMaticenBroj.Checked == true)
            {
                if (tbMaticenBr.Text.Length == 13)
                {
     
                    tbIme.Clear();
                    tbTatkovoIme.Clear();
                    tbPrezime.Clear();
                    tbAdresa.Clear();
                    tbMestoZiveenje.Clear();
                 
                        long maticen;
                        bool parsirajMaticen = Int64.TryParse(tbMaticenBr.Text, out maticen);
                        if (parsirajMaticen)
                        {

                                try
                                {
                                    string uslov = " WHERE maticen=" + maticen;
                                    Database objDatabase = new Database();

                                    var sqlite_datareader = objDatabase.PrikaziGiKadeSto(uslov);
                                    listView1.Items.Clear();
                                    while (sqlite_datareader.Read())
                                    {

                                        string[] arr = new string[9];
                                        ListViewItem itm;

                                        arr[0] = sqlite_datareader.GetInt64(0).ToString();
                                        arr[1] = sqlite_datareader.GetValue(1).ToString();
                                        arr[2] = sqlite_datareader.GetValue(2).ToString();
                                        arr[3] = sqlite_datareader.GetValue(3).ToString();
                                        arr[4] = sqlite_datareader.GetValue(4).ToString();
                                        arr[5] = sqlite_datareader.GetValue(5).ToString();
                                        arr[6] = sqlite_datareader.GetValue(6).ToString();
                                        arr[7] = sqlite_datareader.GetValue(7).ToString();
                                        arr[8] = sqlite_datareader.GetValue(8).ToString();

                                        itm = new ListViewItem(arr);
                                        listView1.Items.Add(itm);

                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Ima problem so vnesuvanjeto vo listview !");
                                }
                        }
                        else
                        {
                            MessageBox.Show("Vo poleto dozvoleni se samo brojki");
                        }
                
                }
                else
                {
                    MessageBox.Show("Popolnetego prvilno so 13 cifri poleto za maticen broj");
                }
            }
            
         

            if (rbIme.Checked == true )
            {
                if (tbIme.Text != "")
                {
                    tbMaticenBr.Clear();
                    tbTatkovoIme.Clear();
                    tbPrezime.Clear();
                    tbAdresa.Clear();
                    tbMestoZiveenje.Clear();
                    try
                    {
                        string uslov = " WHERE ime='" + tbIme.Text+"'";
                        Database objDatabase = new Database();

                        var sqlite_datareader = objDatabase.PrikaziGiKadeSto(uslov);
                        listView1.Items.Clear();
                        while (sqlite_datareader.Read())
                        {

                            string[] arr = new string[9];
                            ListViewItem itm;

                            arr[0] = sqlite_datareader.GetInt64(0).ToString();
                            arr[1] = sqlite_datareader.GetValue(1).ToString();
                            arr[2] = sqlite_datareader.GetValue(2).ToString();
                            arr[3] = sqlite_datareader.GetValue(3).ToString();
                            arr[4] = sqlite_datareader.GetValue(4).ToString();
                            arr[5] = sqlite_datareader.GetValue(5).ToString();
                            arr[6] = sqlite_datareader.GetValue(6).ToString();
                            arr[7] = sqlite_datareader.GetValue(7).ToString();
                            arr[8] = sqlite_datareader.GetValue(8).ToString();

                            itm = new ListViewItem(arr);
                            listView1.Items.Add(itm);

                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ima problem so vnesuvanjeto vo listview !");
                    }
                }
                else
                {
                    MessageBox.Show("Popolnetego poleto za ime");
                }
            }
      


            if (rbImeIprezime.Checked == true)
            {
                if (tbIme.Text != "" && tbPrezime.Text != "")
                {
                    tbMaticenBr.Clear();
                    tbTatkovoIme.Clear();
                    tbAdresa.Clear();
                    tbMestoZiveenje.Clear();
                    try
                    {
                        string uslov = " WHERE ime='" + tbIme.Text+ "' AND prezime='"+ tbPrezime.Text + "'";
                        Database objDatabase = new Database();

                        var sqlite_datareader = objDatabase.PrikaziGiKadeSto(uslov);
                        listView1.Items.Clear();
                        while (sqlite_datareader.Read())
                        {

                            string[] arr = new string[9];
                            ListViewItem itm;

                            arr[0] = sqlite_datareader.GetInt64(0).ToString();
                            arr[1] = sqlite_datareader.GetValue(1).ToString();
                            arr[2] = sqlite_datareader.GetValue(2).ToString();
                            arr[3] = sqlite_datareader.GetValue(3).ToString();
                            arr[4] = sqlite_datareader.GetValue(4).ToString();
                            arr[5] = sqlite_datareader.GetValue(5).ToString();
                            arr[6] = sqlite_datareader.GetValue(6).ToString();
                            arr[7] = sqlite_datareader.GetValue(7).ToString();
                            arr[8] = sqlite_datareader.GetValue(8).ToString();

                            itm = new ListViewItem(arr);
                            listView1.Items.Add(itm);

                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ima problem so vnesuvanjeto vo listview !");
                    }
                }
                else
                {
                    MessageBox.Show("Popolnetegi polinjata za ime i prezime");
                }
            }
          

            if (rbGodina.Checked == true)
            {

                if (cbGodina.Text != "Izberete ucebna godina")
                {
                    tbIme.Clear();
                    tbMaticenBr.Clear();
                    tbTatkovoIme.Clear();
                    tbPrezime.Clear();
                    tbAdresa.Clear();
                    tbMestoZiveenje.Clear();
                    try
                    {
                        string uslov = " WHERE godina_ucebna='" + cbGodina.Text + "'";
                        Database objDatabase = new Database();

                        var sqlite_datareader = objDatabase.PrikaziGiKadeSto(uslov);
                        listView1.Items.Clear();
                        while (sqlite_datareader.Read())
                        {

                            string[] arr = new string[9];
                            ListViewItem itm;

                            arr[0] = sqlite_datareader.GetInt64(0).ToString();
                            arr[1] = sqlite_datareader.GetValue(1).ToString();
                            arr[2] = sqlite_datareader.GetValue(2).ToString();
                            arr[3] = sqlite_datareader.GetValue(3).ToString();
                            arr[4] = sqlite_datareader.GetValue(4).ToString();
                            arr[5] = sqlite_datareader.GetValue(5).ToString();
                            arr[6] = sqlite_datareader.GetValue(6).ToString();
                            arr[7] = sqlite_datareader.GetValue(7).ToString();
                            arr[8] = sqlite_datareader.GetValue(8).ToString();

                            itm = new ListViewItem(arr);
                            listView1.Items.Add(itm);

                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ima problem so vnesuvanjeto vo listview !");
                    }
                }
                else
                {

                    MessageBox.Show("Izberete ucebna godina");
                }
            }
           

            if (rbKlasIgodina.Checked == true)
            {
                if (cbGodina.Text != "Izberete ucebna godina" && cbKlas.Text != "Izberete klas")
                {
                    try
                    {
                        string uslov = " WHERE godina_ucebna='" + cbGodina.Text + "' AND klas='" + cbKlas.Text + "'";
                        Database objDatabase = new Database();

                        var sqlite_datareader = objDatabase.PrikaziGiKadeSto(uslov);
                        listView1.Items.Clear();
                        while (sqlite_datareader.Read())
                        {

                            string[] arr = new string[9];
                            ListViewItem itm;

                            arr[0] = sqlite_datareader.GetInt64(0).ToString();
                            arr[1] = sqlite_datareader.GetValue(1).ToString();
                            arr[2] = sqlite_datareader.GetValue(2).ToString();
                            arr[3] = sqlite_datareader.GetValue(3).ToString();
                            arr[4] = sqlite_datareader.GetValue(4).ToString();
                            arr[5] = sqlite_datareader.GetValue(5).ToString();
                            arr[6] = sqlite_datareader.GetValue(6).ToString();
                            arr[7] = sqlite_datareader.GetValue(7).ToString();
                            arr[8] = sqlite_datareader.GetValue(8).ToString();

                            itm = new ListViewItem(arr);
                            listView1.Items.Add(itm);

                        }
                    }
                    catch
                    {
                        MessageBox.Show("Ima problem so vnesuvanjeto vo listview !");
                    }
                }
                else
                {
                    MessageBox.Show("Izberete ucebna godina i klas");
                }
            }
          
        }

        private void btnNoviPodatoci_Click(object sender, EventArgs e)
        {
            try
            {

                if (tbMaticenBr.Text != "" && tbIme.Text != "" && tbTatkovoIme.Text != "" && tbPrezime.Text != "" && tbAdresa.Text != "" && tbMestoZiveenje.Text != "" && cbKlas.Text != "" && cbGodina.Text != "")
                {
                    if (tbMaticenBr.Text.Length == 13)
                    {
                        long maticen;
                        bool parsirajMaticen = Int64.TryParse(tbMaticenBr.Text, out maticen);
                        if (parsirajMaticen)
                        {
                            string[] arr = new string[9];
                            ListViewItem itm;

                            arr[0] = maticen.ToString();
                            arr[1] = tbIme.Text;
                            arr[2] = tbTatkovoIme.Text;
                            arr[3] = tbPrezime.Text;
                            arr[4] = dtDatumRag.Value.ToString();
                            arr[5] = tbAdresa.Text;
                            arr[6] = tbMestoZiveenje.Text;
                            arr[7] = cbKlas.Text;
                            arr[8] = cbGodina.Text;

                            itm = new ListViewItem(arr);
                            listView1.Items.Add(itm);

                        }
                        else
                        {
                            MessageBox.Show("Vo poleto dozvoleni se samo brojki");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Vnesete ispraven maticen broj od 13 cifri !!!");
                    }

                }
                else
                {
                    MessageBox.Show("Site polinja se zadolzitelni");
                }
            }
            catch { MessageBox.Show("Ima problem so vnesuvanjeto vo baza !"); }
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
                            ////listview koloni
                            //ws.Cells[1, 1] = "Maticen broj";
                            //ws.Cells[1, 2] = "Ime";
                            //ws.Cells[1, 3] = "Tatkovo ime";
                            //ws.Cells[1, 4] = "Prezime";
                            //ws.Cells[1, 5] = "Datum na ragjanje";
                            //ws.Cells[1, 6] = "Adresa";
                            //ws.Cells[1, 7] = "Mesto na ziveenje";
                            //ws.Cells[1, 8] = "Klas";
                            //ws.Cells[1, 9] = "Godina ucebna";
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
                                    ws.Cells[i, 1] = item.SubItems[0].Text;
                                    ws.Cells[i, 2] = item.SubItems[1].Text;
                                    ws.Cells[i, 3] = item.SubItems[2].Text;
                                    ws.Cells[i, 4] = item.SubItems[3].Text;
                                    ws.Cells[i, 5] = item.SubItems[4].Text;
                                    ws.Cells[i, 6] = item.SubItems[5].Text;
                                    ws.Cells[i, 7] = item.SubItems[6].Text;
                                    ws.Cells[i, 8] = item.SubItems[7].Text;
                                    ws.Cells[i, 9] = item.SubItems[8].Text;
                                i++;
                            }

                            // wb.SaveAs(sfd.FileName,XlFileFormat.xlWorkbookDefault,Type.Missing,Type.Missing,true,false,XlSaveAsAccessMode.xlNoChange,XlSaveConflictResolution.xlLocalSessionChanges);
                            //MessageBox.Show(sfd.FileName);
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
            catch {
                MessageBox.Show("Ima problem so exportiranjeto na excel dadotekata");
            }


        }

        private void btnIspratiMeil_Click(object sender, EventArgs e)
        {

            if (tbToEmail.Text != "")
            {
                if (tbAttachemt.Text != "")
                {
                    try
                    {
                        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                        smtpClient.Port = 587;
                        smtpClient.Credentials = new NetworkCredential("vladimirkrstevski337@gmail.com", "ibnz dvho tixw muab");
                        smtpClient.EnableSsl = true;

                        MailMessage mailMessage = new MailMessage();
                        mailMessage.From = new MailAddress("vladimirkrstevski337@gmail.com");
                        mailMessage.To.Add(tbToEmail.Text);
                        mailMessage.Subject = "Испраќам меил преку програмата C# .NET FRAMEWORK";
                        mailMessage.Body = "Почитувани ова е екселот што го баравте";

                        Attachment attachment = new Attachment(tbAttachemt.Text);
                        mailMessage.Attachments.Add(attachment);

                        smtpClient.Send(mailMessage);

                        MessageBox.Show("Uspesno isprativte email do " + tbToEmail.Text + " !!!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Problem so isprakjate email: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Nemate exportirano excel dadoteka od listview !!!");
                }


            }
            else
            {
                MessageBox.Show("Ve molam vnesete email do koj sakte da go ispratite !!!");
            }
        }

        private void btnSendMeil_Click(object sender, EventArgs e)
        {
            if (tbMeilTo.Text != "" )
            {
                    if (tbPathOfExcel.Text != "")
                    {
                        try
                        {
                            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                            smtpClient.Port = 587;
                            smtpClient.Credentials = new NetworkCredential("vladimirkrstevski337@gmail.com", "ibnz dvho tixw muab");
                            smtpClient.EnableSsl = true;

                            MailMessage mailMessage = new MailMessage();
                            mailMessage.From = new MailAddress("vladimirkrstevski337@gmail.com");
                            mailMessage.To.Add(tbMeilTo.Text);
                            mailMessage.Subject = tbMelSubject.Text;
                            mailMessage.Body = tbMeilMessage.Text;

                            Attachment attachment = new Attachment(tbPathOfExcel.Text);
                            mailMessage.Attachments.Add(attachment);

                            smtpClient.Send(mailMessage);

                            MessageBox.Show("Uspesno isprativte email do " + tbMeilTo.Text + " !!!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Problem so isprakjate email: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ima problem so citanje na excel fajlot !!!");
                    }

             
            }
            else
            {
                MessageBox.Show("Ve molam vnesete email do koj sakte da go ispratite !!!");
            }
        }

        private void btnOpenFileForAttach_Click(object sender, EventArgs e)
        {
            this.openFileDialog2.FileName = "*.xls"; if (this.openFileDialog2.ShowDialog() == DialogResult.OK)
            {
               //  MessageBox.Show(this.openFileDialog2.FileName);
                tbPathOfExcel.Text = this.openFileDialog2.FileName; 

            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void tbMeilTo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMeilMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tbPathOfExcel_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMelSubject_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
