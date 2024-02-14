using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Chart_Control
{
    //https://www.c-sharpcorner.com/UploadFile/1e050f/chart-control-in-windows-form-application/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void fillChart()
        {
            //AddXY value in chart1 in series named as Salary  
            chart1.Series["Ucenici"].Points.AddXY("Vladimir", "1");
            chart1.Series["Ucenici"].Points.AddXY("Darko", "2");
            chart1.Series["Ucenici"].Points.AddXY("Hristijan", "3");
            chart1.Series["Ucenici"].Points.AddXY("Davor", "4");
            chart1.Series["Ucenici"].Points.AddXY("Mario", "5");
            //chart title  
            chart1.Titles.Add("Tabela so ucenki");
        }

        //fillChart method  
        private void fillChartDatabase()
        {
            SqlConnection con = new SqlConnection("Data Source=C:\\SQLite\\Z64.LicnostiPodatoci.db;Initial Catalog=Sample;Integrated Security=true;");
            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("Select Name,Salary from tbl_EmpSalary", con);
            adapt.Fill(ds);
            chart1.DataSource = ds;
            //set the member of the chart data source used to data bind to the X-values of the series  
            chart1.Series["Ucenici"].XValueMember = "iminja";
            //set the member columns of the chart data source used to data bind to the X-values of the series  
            chart1.Series["Ucenici"].YValueMembers = "ocenki";
            chart1.Titles.Add("Salary Chart");
            con.Close();

        }

        private void chart1_Click(object sender, EventArgs e)
        {
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
            fillChart();
        }
    }
}
