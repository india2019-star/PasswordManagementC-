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
    public partial class insertuc : UserControl
    {
        public insertuc()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void insertuc_Load(object sender, EventArgs e)
        {
            clearAll();
        }


        public bool checkcardnumber(string cnum)
        {
            for (int i = 0; i < cnum.Length; i++)
            {
                if (!Char.IsDigit(cnum[i]))
                {
                    return false;
                }
            }
            return true;
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string cnumber = cardnumber.Text;
            string ctype = cardtype.Text;
            string cpin = cardpin.Text;
            string cname = cardname.Text;

            if(cnumber != "" && ctype != "" && cpin != "" && cname != ""  && cnumber.Length == 16 && checkcardnumber(cnumber) == true)
            {
                Form1 ff = new Form1();
                cpin = ff.Encryptpassword(cpin);
                long cnum = Convert.ToInt64(cnumber);
                string query = "Insert into CardDetails VALUES('" + cnum + "', '" + ctype + "', '" + cpin + "', '" + cname + "')";
                Adddata ad = new Adddata();
                ad.insertingdata(query);
            }
            else
            {
                MessageBox.Show("Fields Cannot be empty or invalid details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clearAll();
        }

        public void clearAll()
        {
            cardnumber.Clear();
            cardname.Clear();
            cardpin.Clear();
            cardtype.Clear();
        }
    }
}
