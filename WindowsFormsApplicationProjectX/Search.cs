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
            source = new AutoCompleteStringCollection();
            connect = Connection.getConnection();
            // adapter = new OleDbDataAdapter("SELECT name FROM sys.Tables", connect.Con);
            //ds = new DataSet();          
        }

        public AutoCompleteStringCollection fillSource()
        {
            //adapter.Fill(ds, "sys.Tables");
            //connect = new Connection();
            OleDbCommand cmd;
            
            cmd = connect.Con.CreateCommand();
            cmd.CommandText = "SELECT name FROM sys.Tables";
            cmd.CommandType = CommandType.Text;

             //new OleDbCommand("SELECT name FROM sys.Tables", connect.Con);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //source.Add(reader["name"].ToString());
                source.Add(reader[2].ToString());
            }

            //connect.close();
            return source;
                
           
        }


    }
}
