using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationProjectX
{
    public class Search
    {
        AutoCompleteStringCollection source;
        Connection connect;
       // OleDbDataAdapter adapter;
        //DataSet ds;
        
        public Search()
        {
            connect = new Connection();
            source = new AutoCompleteStringCollection();
            // adapter = new OleDbDataAdapter("SELECT name FROM sys.Tables", connect.Con);
            //ds = new DataSet();          
        }

        public AutoCompleteStringCollection fillSource()
        {
            //adapter.Fill(ds, "sys.Tables");
            OleDbCommand cmd = new OleDbCommand("SELECT name FROM sys.Tables", connect.Con);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                source.Add(reader["name"].ToString());
            }

            return source;
                
           
        }


    }
}
