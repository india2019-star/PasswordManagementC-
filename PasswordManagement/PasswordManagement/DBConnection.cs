using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace PasswordManagement
{
    class DBConnection
    {
        public SqlConnection GetConnection()
        {
            string connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Raj\\source\\repos\\PasswordManagement\\PasswordManagement\\ManagementDatabase.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionstring);
            return conn;
        }
    }
}
