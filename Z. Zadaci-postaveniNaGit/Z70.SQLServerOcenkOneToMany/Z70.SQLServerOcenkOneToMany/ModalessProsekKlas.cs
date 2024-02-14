using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z70.SQLServerOcenkOneToMany
{
    public partial class ModalessProsekKlas : Form
    {
        public ModalessProsekKlas()
        {
            InitializeComponent();
            richTextBox1.Text = Form1.prosekKlas;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModalessProsekKlas_Load(object sender, EventArgs e)
        {

        }
    }
}
