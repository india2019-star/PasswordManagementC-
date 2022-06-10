using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace PasswordManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public string Encryptpassword(string password)
        {
            using(MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf.GetBytes(password));
                return Convert.ToBase64String(data);
            }
            
        }




        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();
            SqlConnection conn = db.GetConnection();
            conn.Open();
            if (emaildata.Text != "" && passworddata.Text != "")
            {
                string email = emaildata.Text;
                string password = Encryptpassword(passworddata.Text);
                string query = "Select * from AdminDetails where email =@email  and password =@password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                SqlDataReader reader = cmd.ExecuteReader();
                int cnt = 0;
                while(reader.Read())
                {
                    cnt++;
                }
                if (cnt > 0)
                {
                    PasswordWarehouse ps = new PasswordWarehouse();
                    ps.Show();
                    this.Hide();
                }
                else
                {
                   
                    MessageBox.Show("Email or Password Invalid. IF not a registered user please register yourself.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Email or password cannot be empty", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

            Register rg = new Register();
            rg.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
