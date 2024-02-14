using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z68.SQLServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtBoxIme.Text);
            MessageBox.Show(txtBoxPrezime.Text);
            MessageBox.Show(txtBoxGodini.Text);
        }

 
    }
}
