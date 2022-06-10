using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Collections.Specialized;
using System.IO;
using System.Web;
using System.Net;
using System.Net.Mail;

namespace PasswordManagement
{
    public partial class viewuc : UserControl
    {
        public viewuc()
        {
            InitializeComponent();
        }

        private void viewuc_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string randomnumber;
        protected int n;
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            insertuc ic = new insertuc();
            if(randomnumber == otp.Text && cardnumberview.Text != "" && cardnumberview.Text.Length == 16 && ic.checkcardnumber(cardnumberview.Text) == true)
            {
                string cnum = cardnumberview.Text;
                string query = "Select * from CardDetails where cardnumber = '" + cnum + "'";
                DataView dv = new DataView();
                DataSet ds = new DataSet();
                ds = dv.getdata(query);
                n = gridview.Rows.Add();
                gridview.Rows[n].Cells[0].Value = ds.Tables[0].Rows[0][1];
                gridview.Rows[n].Cells[1].Value = ds.Tables[0].Rows[0][2].ToString();
                gridview.Rows[n].Cells[2].Value = ds.Tables[0].Rows[0][3].ToString();
                gridview.Rows[n].Cells[3].Value = ds.Tables[0].Rows[0][4].ToString();
            }
            else
            {
                MessageBox.Show(randomnumber, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show("Otp not matched or invalid card number. please try again.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

            
            Random rnd = new Random();
            randomnumber = (rnd.Next(10000, 99999)).ToString();
            try
            {

                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("fieldmarshaltesting@gmail.com");
                msg.To.Add(emailid.Text);
                msg.Subject = "OTP verification";
                msg.Body = randomnumber;

                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.gmail.com";
                System.Net.NetworkCredential ntcd = new NetworkCredential();
                ntcd.UserName = "fieldmarshaltesting@gmail.com";
                ntcd.Password = "jaihind220500";
                smt.Credentials = ntcd;
                smt.EnableSsl = true;
                smt.Port = 587;
                smt.Send(msg);

                MessageBox.Show("Your Mail has been sent");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
