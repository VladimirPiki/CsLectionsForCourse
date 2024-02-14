using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z68.OcenkiOneToMany
{
    public partial class ModalMeil : Form
    {
        public ModalMeil()
        {
            InitializeComponent();
        }

        private void btnSendMeil_Click(object sender, EventArgs e)
        {
            if (tbMeilTo.Text != "")
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

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void tbPathOfExcel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void tbMeilTo_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tbMeilMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMelSubject_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModalMeil_Load(object sender, EventArgs e)
        {

        }
    }
}
