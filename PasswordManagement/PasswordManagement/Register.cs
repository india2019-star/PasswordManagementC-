using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManagement
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1 ff = new Form1();
            string email = registeremail.Text;
            string password = registerpass.Text;
            string confirm_password = registerconfirm.Text;
            if(email != "" && password != "" && confirm_password != "" && password == confirm_password)
            {
                password = ff.Encryptpassword(registerpass.Text);
                string query = "Insert into AdminDetails VALUES('" + email + "','" + password + "')";
                Adddata ad = new Adddata();
                ad.insertingdata(query);
            }
            else
            {
                MessageBox.Show("Email or password cannot be empty. Also please check password and confirme password fields. They should be same.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form1 ff = new Form1();
            ff.Show();
            this.Hide();
        }

        private void registerpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerconfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
