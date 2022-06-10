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
    public partial class PasswordWarehouse : Form
    {
        public PasswordWarehouse()
        {
            InitializeComponent();
            insertuc1.Visible = true;
            insertuc1.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            insertuc1.Visible = true;
            insertuc1.BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            updateuc1.Visible = true;
            updateuc1.BringToFront();
            insertuc1.Hide();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            deleteuc1.Visible = true;
            deleteuc1.BringToFront();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form1 ff = new Form1();
            ff.Show();
            this.Hide();
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void insertuc1_Load(object sender, EventArgs e)
        {
            
        }

        private void updateuc1_Load(object sender, EventArgs e)
        {

        }

        private void viewuc1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            viewuc1.Visible = true;
            viewuc1.BringToFront();
        }
    }
}
