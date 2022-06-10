using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace PasswordManagement
{
    class Adddata
    {
        public void insertingdata(string query)
        {
            DBConnection db = new DBConnection();
            SqlConnection conn = db.GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int rows = cmd.ExecuteNonQuery();
            if(rows > 0)
            {
                MessageBox.Show("Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Insertion Failed. Please try again", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
