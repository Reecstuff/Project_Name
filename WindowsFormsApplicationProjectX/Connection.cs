using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace WindowsFormsApplicationProjectX
{
    class Connection
    {
        OleDbConnection con;
        public Connection()
        {
            connect();
        }

        public void connect()
        {
            con = new OleDbConnection();
            con.ConnectionString = Properties.Settings.Default.DbPath;
            con.Open();
        }
    }
}
