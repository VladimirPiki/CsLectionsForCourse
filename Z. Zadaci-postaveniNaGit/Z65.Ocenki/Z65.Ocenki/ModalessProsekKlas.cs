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

namespace Z65.Ocenki
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
    }
}
