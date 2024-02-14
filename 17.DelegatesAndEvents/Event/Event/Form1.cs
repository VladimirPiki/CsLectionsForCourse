using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event
{
    //Апликациите и прозорците комуницираат преку претходно дефинирани пораки. Овие пораки содржат различни информации за одредување на дејствата на прозорецот и апликацијата. .NET ги смета овие пораки како настан. Ќе се справите со соодветниот настан доколку треба да реагирате на одредена дојдовна порака.

    //nastanite nemozat da se kreirat bez delegati
    public delegate void DelEventHandler();
    public partial class Form1 : Form
    {
        //custom event
        public event DelEventHandler add;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }


}
