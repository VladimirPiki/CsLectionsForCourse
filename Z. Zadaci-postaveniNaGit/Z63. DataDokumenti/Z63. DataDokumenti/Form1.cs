using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SQLite;
using System.Globalization;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;
using System.IO;
using System.Drawing.Printing;
using System.Xml.Linq;
using Microsoft.Office.Interop.Word;

namespace Z63.DataDokumenti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.View = System.Windows.Forms.View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("id", 200);
            listView1.Columns.Add("naslov", 200);
            listView1.Columns.Add("avtor", 200);
            listView1.Columns.Add("datum", 200);
            listView1.Columns.Add("mesto", 200);
            listView1.Columns.Add("lokacija", 200);
            listView1.Columns.Add("oblast", 200);
            listView1.Columns.Add("slika", 200);

 

            //citanje na podatocite od baza i zapisuvanje vo listview1
            //SQLiteConnection sqlite_conn;
            //sqlite_conn = CreateConnection();

            //ReadData(sqlite_conn);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        static SQLiteConnection CreateConnection()
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source= C:\\SQLite\\dokumenti.db; Version = 3; New = True; Compress = True; ");
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

        public void ReadData(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Dokumenti";


            sqlite_datareader = sqlite_cmd.ExecuteReader();
            listView1.Items.Clear();
            while (sqlite_datareader.Read())
            {

                string[] arr = new string[9];
                ListViewItem itm;

                arr[0] = sqlite_datareader.GetInt32(0).ToString();
                arr[1] = sqlite_datareader.GetValue(1).ToString();
                arr[2] = sqlite_datareader.GetValue(2).ToString();
                arr[3] = sqlite_datareader.GetValue(3).ToString();
                arr[4] = sqlite_datareader.GetValue(4).ToString();
                arr[5] = sqlite_datareader.GetValue(5).ToString();
                arr[6] = sqlite_datareader.GetValue(6).ToString();
                arr[7] = sqlite_datareader.GetValue(7).ToString();

                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);

            }
        }
        public void ReadDataUslov(SQLiteConnection conn, string prebaruvanje)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM Dokumenti " + prebaruvanje;


            sqlite_datareader = sqlite_cmd.ExecuteReader();
            listView1.Items.Clear();
            while (sqlite_datareader.Read())
            {

                string[] arr = new string[9];
                ListViewItem itm;

                arr[0] = sqlite_datareader.GetInt32(0).ToString();
                arr[1] = sqlite_datareader.GetValue(1).ToString();
                arr[2] = sqlite_datareader.GetValue(2).ToString();
                arr[3] = sqlite_datareader.GetValue(3).ToString();
                arr[4] = sqlite_datareader.GetValue(4).ToString();
                arr[5] = sqlite_datareader.GetValue(5).ToString();
                arr[6] = sqlite_datareader.GetValue(6).ToString();
                arr[7] = sqlite_datareader.GetValue(7).ToString();


                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);


            }
        }

        static void CreateTable(SQLiteConnection conn)
        {

            SQLiteCommand sqlite_cmd;

            //proverka dali postoi tabela vo bazata
            string daliPostoiTabela = "SELECT name FROM sqlite_master WHERE type = 'table' AND name = 'Dokumenti'";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = daliPostoiTabela;
            var exists = sqlite_cmd.ExecuteReader();
            if (!exists.HasRows)
            {
                string createTable = "CREATE TABLE Dokumenti(id INTEGER PRIMARY KEY AUTOINCREMENT,naslov VARCHAR(100),avtor VARCHAR(100),datum DATE,mesto VARCHAR(100),lokacija mesto VARCHAR(100),oblast VARCHAR(100),slika VARCHAR(100))";
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = createTable;
                sqlite_cmd.ExecuteNonQuery();
            }

        }

        public void KreirajWordDokument(string lokacija,string naslov)
        {
            if(lokacija  != "" && naslov != "")
            {
                // Create a new instance of Microsoft Word application
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();

                // Create a new document
                Microsoft.Office.Interop.Word.Document doc = wordApp.Documents.Add();

                // Add content to the document
                Microsoft.Office.Interop.Word.Paragraph para = doc.Paragraphs.Add();
                para.Range.Text = "Македонија\r\nИсторија\r\nГлавни статии: Историја на македонскиот народ и Историја на Македонија\r\nПраисторија\r\n Мегалитската опсерваторија Кокино\r\nНајстарите траги од животот на луѓето во Македонија потекнуваат од времето на неолитот, односно од времето кога постоело примитивно земјоделство. Покрај земјоделството, луѓето во ова време ја познавале, изработувале и употребувале керамиката, во вид на садови за секојдневна употреба, или како вајани идоли на божества и човечки фигури. Од страна на оружје во ова време била користена праќата.\r\nЗа време на бронзеното време, особеност на населбите во Македонија е тоа што биле градени на високи и тешко достапни места, што наведува на големи преселби на разни племиња. Преодниот период од бронзеното во железното време (XII — XI век п.н.е.) е одбележан со големи преселби на население од север, во науката познати како Егејски преселби, со цел освојување на богати градови во Југоисточниот Медитеран. Притоа, дошло до уништување на микенската култура. Дел од преселбите се одвивале по долината на Вардар, па, така, повеќе населби од тој период се уништени, главно со опожарување.\r\nАнтичка Македонија\r\n Античкиот град Хераклеја, основан од страна на Филип II Македонски, во близина на денешна Битола. Ѕвездата од Кутлеш — симбол на Античка Македонија.\r\nАрхеолошките наоди покажуваат дека на просторот на Македонија постоела цивилизација уште од периодот меѓу 9000 п.н.е. и 3500 п.н.е.[15] Првпат Македонското Кралство се појавува во периодот на IX век п.н.е., а постои недоумица за тоа кој бил првиот македонски крал — Каран, кој се смета за митски предок на Аргеадите, или Пердика I — првиот историски крал на Кралството Македонија.\r\nПриближно од V век п.н.е. Кралството Македонија станува значаен политичко-економски чинител во поширокиот регион, а негова главна надворешнополитичка дејност била сосредоточена кон односите со грчките градови-држави, при што често било сојузник со други држави (како на пр. Персија) против Грците, или пак заземало страна во некои од меѓусебните спорови на градовите, настојувајќи на тој начин да го уништи нивното единство и да ги ослаби. Филип II Македонски (359 г. п.н.е. — 336 г. п.н.е.), по покорувањето на Илирите и Тракијците, успеал да ја освои цела Грција. Неговиот син, Александар III Македонски (336 г. п.н.е. — 323 г. п.н.е.) е една од најзначајните личности во светската историја. Тој најпрвин го скршил внатрешниот отпор во проширеното Македонско Кралство, а подоцна во походот против Персија, ја уништил огромната Персиска Империја и ја проширил македонската држава на три континенти — Европа, Азија и Африка, протегајќи се на Балканскиот Полуостров и Мала Азија, Блискиот Исток, Египет и Индија, и со тоа била создадена Македонската Империја.[16][17][18][19][20][21][22][23] По неговата смрт, оваа огромна империја, како резултат на несогласувањата на неговите генерали (дијадоси) околу тоа кој ќе биде негов наследник се распаднала на 3 дела и тоа: Кралството на Селевкидите, Кралството на Птолемаидите и Кралството на Антигонидите.[24][25] Освојувањата на Александар III Македонски имаат суштествено значење за започнувањето на хеленистичкиот период во светската историја.\r\nПродорот на Римска Република на исток доведува до таканаречените Македонско-римски војни (215 г. п.н.е. — 168 г. п.н.е.) во кои Македонското Кралство управувано од Династијата на Антигонидите целосно потпаѓа под римска власт, а последниот македонски крал Персеј e одведен како роб во Рим. Таа станува римска провинција како дел од Римското Царство и е поделена на 2 дела — Македонија Прима и Македонија Салутарис.[26] Територијата на денешна Македонија била поделена меѓу провинциите Македонија Салутарис и Моезија прима.[27] По поделбата на Римското Царство во 395 г. од н.е. на Источно и Западно Римско Царство, Македонија станува дел од Источното Римско Царство или Византија.\r\nПојавата на Словените\r\n Самуиловата тврдина во Охрид.\r\nВо VI и VII век на Балканот и во Македонија се доселуваат Словените, достигнувајќи јужно до Тесалија, па дури и до Пелопонез.[28] Тие се измешале со затекнатото месно население, во најголема мера со Тракијци и Илири, потоа Стари Грци, Антички Македонци, и др. На македонската територија, која тогаш се наоѓала под византиска јурисдикција, македонските Словени биле опфатени во полудржавни формации — македонски склавинии. Склавиниите презеле повеќе напади против Византија и утврдените византиски градови.\r\nВо 837 година Македонија почнува да потпаѓа под власта на бугарската држава, при што до средината на IX век поголемиот дел од Македонија потпаднал под бугарска власт, а другиот бил вклучен во рамките на Византија. Во IX век, исто така, започнува и црковнопросветната дејност на солуњаните Кирил и Методиј, која се состоела од повеќе мисии за покрстување на Словените, но и во поставување на основите на словенската писменост, која започнува со создавањето на словенската азбука — глаголицата, во 855 година. Нивните ученици, Климент и Наум, ќе ја продолжат нивната дејност и кон крајот на IX век, ќе ја создадат Охридската книжевна школа и Преславската книжевна школа, со што Охрид набрзо прераснува во еден од најразвиените црковнопросветни и културни средишта на Балканот — лулка на словенската писменост.\r\n \r\nОваа статија е дел од целината\r\nИсторија на Македонија\r\n\r\nприкажи\r\nПраисторија\r\n\r\nприкажи\r\nАнтика\r\n\r\nприкажи\r\nСреден век\r\n\r\nприкажи\r\nОсманлиска Македонија\r\n\r\nприкажи\r\nСовремена Македонија\r\n\r\nприкажи\r\nНезависна Македонија\r\n\r\nСписок: Историјата на Македонија по години\r\n\r\n•\tп\r\n•\tр\r\n•\tу\r\n\r\nВо X век Македонија ќе ја зафати богомилското движење и учење, за првпат создадено во Велешко-прилепската Област, како одглас на потчинувачкиот феудален црковноекономски систем. Тоа набрзо ќе се прошири не само во Македонија, туку и низ цела Европа.\r\nСо востанијата во Македонија во втората половина на X век, во 969 година против бугарската и во 976 година против византиската власт била создадена македонската средновековна феудална држава, позната уште и како Самуиловото Царство). Македонската средновековна феудална држава постоела сè до 1018 година, кога била покорена од византиските војски. Во XIII и XIV век византиската власт врз Македонија била прекинувана со времиња на српско и бугарско владеење.\r\nДо крајот на XIV век Македонија целосно била покорена од Османлиите, со што нејзиниот економски и општествен систем бил разорен, а исто така, бил забавен и нејзиниот натамошен општествен и културен развој. Во 1767 година султанот ја укинал Охридската архиепископија.\r\nОсвестување и обединување на македонската нација во XIX век\r\nГлавна статија: Зацврстување на народниот јазик во црковната литература до почетокот на XIX век\r\nЗацврстување на народниот јазик\r\n Архитектурата во градот Охрид.\r\nОд XIV век во Македонија започнува да се засилува влијанието на српската варијанта на старословенскиот јазик. Причина за тоа било приклучувањето на македонските краишта кон тогашната српска држава. Тоа влијание се однесува главно, на правописот. Покрај тоа, во книжевните споменици од тоа време сè повидливи се и трагите од современите живи македонски говори.\r\nВо времето на Отоманското Царство писменоста доживува опаѓање. Нејзиниот јазик уште повеќе се оддалечува од старословенската основа, затоа што во живиот народен говор веќе биле насобрани повеќе изразити промени. Покрај црковните богослужбени книги, во кои повеќе се водело сметка за старата писмена словенска традиција, се појавуваат сè повеќе и такви текстови што служат за читање на поширок круг луѓе или претставуваат написи за практична употреба.\r\nВо XVI век се печатат и книги во Србија и Венеција. Во XVII век веќе доаѓаат во големи количества црковни книги печатени во Русија на рускословенски јазик.\r\nМакедонско национално движење\r\nГлавна статија: Македонско национално движење\r\n Весникот Автономна Македонија, Белград 1905\r\nЗа време на османското владеење положбата на Македонците и создавањето на македонска држава биле многу тешки. Неколку движења, чии цели се создавање на автономна Македонија, која го покрива целиот регион на Македонија, започнале да се појавуваат кон крајот на XIX век, а најстарата од нив е Македонската револуционерна организација. Во 1905 година таа била преименувана во Внатрешна македонско-одринска револуционерна организација (ВМОРО), а по Втората светска војна организацијата се поделила на Внатрешна македонска револуционерна организација (ВМРО) и Внатрешна тракиска револуционерна организација (ВТРО). Во почетокот организацијата не бирала националности туку била отворена за „... обединување на сите незадоволни елементи во Македонија и Одринско, без оглед на нивната националност...“ Поголемиот дел од членовите сепак биле Македонци. Во 1903 година ВМРО организира Илинденското востание против Османлиите, кои по некои првични успеси, вклучувајќи и формирање на Крушевската Република, било задушено со големи човечки загуби. Востанието и образувањето на Крушевската Република подоцна многу ќе влијаат кон создавањето на денешната Република.\r\nDokument 1\r\n";
      
                try
                {
                    string filePath = lokacija+"\\"+naslov + ".docx";
                    if (!File.Exists(filePath))
                    {
                        doc.SaveAs2(filePath);
                        doc.Close();
                        wordApp.Quit();
                    }
      
          
                }
                catch
                {
                    MessageBox.Show("Dadoteka ne mozi da se zacuva");
                }

            }
 
        }

        public void PdfFile(string imeFile)
        {
            if (imeFile != "")
            {
                
                //Creating iTextSharp Table from the DataTable data
                iTextSharp.text.Paragraph p1 = new iTextSharp.text.Paragraph("Naslov na dolumentot: " + tbNaslov.Text + "\n" + "Avtor na dokumentot: " + tbAvtor.Text + "\n" + "Datum na izdavanje: " + dtData.Text + "\n" + "Oblast: " + cbOblast.Text);

                iTextSharp.text.Image slika = iTextSharp.text.Image.GetInstance(tbSlika.Text);
                //Resize image depend upon your need
                slika.ScaleToFit(540f, 420f);
                //Give space before image
                slika.SpacingBefore = 10f;
                //Give some space after the image
                slika.SpacingAfter = 1f;
                slika.Alignment = Element.ALIGN_LEFT;
                //Exporting to PDF

                string folderPath = tbLokacijaZacuvaj.Text;


                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                    using (FileStream stream = new FileStream(folderPath + "\\" + imeFile + ".pdf", FileMode.Create))
                    {
                        iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A2, 50f, 50f, 50f, 0f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(p1);
                        pdfDoc.Add(slika);
                        pdfDoc.Close();
                        stream.Close();
                    }
                }
                using (FileStream stream = new FileStream(folderPath + imeFile + ".pdf", FileMode.Create))
                {
                    iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A2, 10f, 10f, 10f, 0f);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();
                    pdfDoc.Add(p1);
                    pdfDoc.Add(slika);
                    pdfDoc.Close();
                    stream.Close();
                }

            }
            else
            {
                MessageBox.Show("Vnesete ime na pdf dadotekata");
            }
        }


        private void btIzberiSlika_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                pictureBox.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
                tbSlika.Text = openFileDialog1.FileName;
            }

        }

        private void btZacuvaj_Click_1(object sender, EventArgs e)
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            CreateTable(sqlite_conn);
            try
            {
                SQLiteCommand cmd;
                cmd = sqlite_conn.CreateCommand();

                cmd.CommandText = @"INSERT INTO Dokumenti(naslov, avtor, datum,mesto,lokacija,oblast,slika)  VALUES (@naslov, @avtor, @datum,@mesto,@lokacija, @oblast, @slika)";

                cmd.Parameters.AddWithValue("@naslov", tbNaslov.Text);
                cmd.Parameters.AddWithValue("@avtor", tbAvtor.Text);

               // DateTime selectedDateTime = dtData.Value;
               // DateTime selectedDate = selectedDateTime.Date;
               //// cmd.Parameters.AddWithValue("@datum", selectedDate);

               // string formattedDate = selectedDate.ToString("dd.MM.yyyy");
               // //cmd.Parameters.AddWithValue("@datum", selectedDate);

                //bool data= DateOnly.TryParse(dtData.Value.Date.ToString(), out DateOnly result);
                //  if (data)
                //  {
                //      cmd.Parameters.AddWithValue("@datum", result);
                //  }


                  cmd.Parameters.AddWithValue("@datum", dtData.Value.Date);
                cmd.Parameters.AddWithValue("@mesto", tbMestoNaIzdavanje.Text);
                cmd.Parameters.AddWithValue("@lokacija", tbLokacijaZacuvaj.Text);
                cmd.Parameters.AddWithValue("@oblast", cbOblast.Text);
                cmd.Parameters.AddWithValue("@slika", tbSlika.Text);
                cmd.ExecuteNonQuery();



            }
            catch (System.Exception excpt)
            {
                MessageBox.Show("Problem so zapisuvanje vo tabelata, mozno povtoruvanje na id " + excpt);
            }

            try
            {

                PdfFile(tbNaslov.Text);
                KreirajWordDokument(tbLokacijaZacuvaj.Text, tbNaslov.Text);
            }
            catch
            {
                MessageBox.Show("Imate problem so vnesuvanje na pdf dadoteka");
            }
        }

        private void btnDownload_Click_1(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 1)
            {
                if (tbImePdf.Text != "")
                {
                    //Creating iTextSharp Table from the DataTable data
                    PdfPTable pdfTable = new PdfPTable(listView1.Columns.Count);
                    pdfTable.DefaultCell.Padding = 3;
                    pdfTable.WidthPercentage = 100;
                    pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                    pdfTable.DefaultCell.BorderWidth = 1;

                    //Adding Header row
                    foreach (ColumnHeader column in listView1.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.Text));
                        pdfTable.AddCell(cell);
                    }

                    //Adding DataRow
                    foreach (ListViewItem itemRow in listView1.Items)
                    {
                        int i = 0;
                        for (i = 0; i < itemRow.SubItems.Count - 1; i++)
                        {
                            pdfTable.AddCell(itemRow.SubItems[i].Text);
                        }
                    }

                    //Exporting to PDF
                    string folderPath = @"C:/temp/";
                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    using (FileStream stream = new FileStream(folderPath + tbImePdf.Text + ".pdf", FileMode.Create))
                    {
                        iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A2, 10f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        pdfDoc.Add(pdfTable);
                        pdfDoc.Close();
                        stream.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Vnesete ime na pdf dadotekata");
                }

            }
            else
            {
                MessageBox.Show("Vnesete vo listview tabelata");
            }
        }

        private void btDodaj_Click_1(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection sqlite_conn;
                sqlite_conn = CreateConnection();
                ReadData(sqlite_conn);
            }
            catch
            {
                MessageBox.Show("Problem so prikazuvanjeto na podatocite");
            }
        }

        private void btnPrebaruvanje_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (tbPrebaruvanjeAvtor.Text != "")
                {
                    string prebaruvanje = " WHERE avtor = '" + tbPrebaruvanjeAvtor.Text + "'";
                    SQLiteConnection sqlite_conn;
                    sqlite_conn = CreateConnection();
                    ReadDataUslov(sqlite_conn, prebaruvanje);
                }
                else
                {
                    MessageBox.Show("Zadolzitelno poplnete go poleto za prebaruvanje po avtor");
                }
            }
            catch
            {
                MessageBox.Show("Ima problem so prebaruvanje po avtor");
            }
        }
        private void btnPrebaruvanjeNaslov_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbPrebaruvanjeNaslov.Text != "")
                {
                    string prebaruvanje = " WHERE naslov = '" + tbPrebaruvanjeNaslov.Text + "'";
                    SQLiteConnection sqlite_conn;
                    sqlite_conn = CreateConnection();
                    ReadDataUslov(sqlite_conn, prebaruvanje);
                }
                else
                {
                    MessageBox.Show("Zadolzitelno poplnete go poleto za prebaruvanje po naslov");
                }
            }
            catch
            {
                MessageBox.Show("Ima problem so prebaruvanje po naslov");
            }
        }


        private void btnPodreduvanjeAvtor_Click(object sender, EventArgs e)
        {
            try
            {
                    string prebaruvanje = " ORDER BY avtor ASC";
                    SQLiteConnection sqlite_conn;
                    sqlite_conn = CreateConnection();
                    ReadDataUslov(sqlite_conn, prebaruvanje);
   
            }
            catch
            {
                MessageBox.Show("Ima problem so podreduvanjeto po avtor");
            }
        }


        private void btnPodreduvanjeOblast_Click(object sender, EventArgs e)
        {
            try
            {
                string prebaruvanje = " ORDER BY oblast ASC";
                SQLiteConnection sqlite_conn;
                sqlite_conn = CreateConnection();
                ReadDataUslov(sqlite_conn, prebaruvanje);

            }
            catch
            {
                MessageBox.Show("Ima problem so podreduvanjeto po oblast");
            }
        }

        private void btnPodreduvanjeNaslov_Click(object sender, EventArgs e)
        {
            try
            {
                string prebaruvanje = " ORDER BY naslov ASC";
                SQLiteConnection sqlite_conn;
                sqlite_conn = CreateConnection();
                ReadDataUslov(sqlite_conn, prebaruvanje);

            }
            catch
            {
                MessageBox.Show("Ima problem so podreduvanjeto po naslov");
            }
        }

        private void btnPodreduvanjeGodiniMesto_Click(object sender, EventArgs e)
        {
            try
            {
                string prebaruvanje = " ORDER BY mesto ASC, datum ASC";
                SQLiteConnection sqlite_conn;
                sqlite_conn = CreateConnection();
                ReadDataUslov(sqlite_conn, prebaruvanje);

            }
            catch
            {
                MessageBox.Show("Ima problem so podreduvanjeto po godini na izdavanje i mesto");
            }
        }

        private void btnPrikazi_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems[0].Text != "")
                {
                    string imeNaPdf = listView1.SelectedItems[0].SubItems[1].Text + ".pdf";
                    string lokacija = listView1.SelectedItems[0].SubItems[5].Text;
                    axAcroPDF1.src = lokacija + imeNaPdf;
                }
            }
            catch
            {
                MessageBox.Show("Ima problem so vcitvanjeto na pdf fajlot");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                if (listView1.SelectedItems.Count > 0)
                {
                    string imeNaWord = listView1.SelectedItems[0].SubItems[1].Text + ".docx";
                    string lokacija = listView1.SelectedItems[0].SubItems[5].Text;
                    Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                    string filePath = lokacija + imeNaWord;
                    if (File.Exists(filePath))
                    {
                        try
                        {
                            Microsoft.Office.Interop.Word.Document doc = wordApp.Documents.Open(filePath);
                            wordApp.Visible = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Imate problem: " + ex.Message);
                        }

                        System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);

                    }
                    else
                    {
                        MessageBox.Show("Dadotekata ne postoi");
                    }

                }
            } catch
            {
                MessageBox.Show("Ima problem so otvaranje na word");
            }


        }

        private void btnOtvoriLokacija_Click(object sender, EventArgs e)
        {
            try {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Word Documents|*.doc;*.docx|All Files|*.*";
                    openFileDialog.Title = "Open a Word Document";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string selectedFilePath = openFileDialog.FileName;
                    //    MessageBox.Show(selectedFilePath);
      

                        //  string fileName = Path.GetFileName(selectedFilePath);
                        string fileName = Path.GetFileNameWithoutExtension(selectedFilePath);
                        tbNaslov.Text = fileName;
                        string folderPath = Path.GetDirectoryName(selectedFilePath);
                       // MessageBox.Show(folderPath);
                        tbLokacijaZacuvaj.Text = folderPath+"\\";
                        //    MessageBox.Show(fileName);


                        Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                        try
                        {
                            Microsoft.Office.Interop.Word.Document doc = wordApp.Documents.Open(selectedFilePath);
                            wordApp.Visible = true;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Imate problem: " + ex.Message);
                        }

                        System.Runtime.InteropServices.Marshal.ReleaseComObject(wordApp);
                    }
                }
            }
            catch { MessageBox.Show("Imate problem so otvoranje na word dadoteka"); }
          
        }
    }
}
