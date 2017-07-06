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
       
        Connection connect;
        
       // OleDbDataAdapter adapter;
        //DataSet ds;
        
        public Search()
        {         
            
            connect = Connection.getConnection();
            // adapter = new OleDbDataAdapter("SELECT name FROM sys.Tables", connect.Con);
            //ds = new DataSet();          
        }

        public AutoCompleteStringCollection fillSource()
        {
            //adapter.Fill(ds, "sys.Tables");
            //connect = new Connection();
            //OleDbCommand cmd;

            //cmd = connect.Con.CreateCommand();
            ////cmd.CommandText = "SELECT name FROM sys.Tables";
            ////cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "SELECT * FROM sys.Tables WHERE type = 'U'";

            ////cmd.CommandText = "Select * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";
            //cmd.CommandType = CommandType.Text;    

            //OleDbCommand cmd = new OleDbCommand("SELECT Name FROM MSysObjects WHERE(Name Not Like 'MSys*') AND(Type In(1, 4, 6))  ORDER BY Name ", connect.Con);
            //OleDbDataReader reader = cmd.ExecuteReader();

            //while (reader.Read())
            //{
            //    source.Add(reader.GetString(0));
            //    //source.Add(reader["name"].ToString());
            //    //source.Add(reader[2].ToString());
            //}
            //Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\@Schule\C#\GitRep\DatenbankCS.accdb;Jet OLEDB:SystemDatabase=C:\Users\User\AppData\Roaming\Microsoft\Access\System.mdw;extended properties=Excel 8.0

            AutoCompleteStringCollection source;
            source = new AutoCompleteStringCollection();

            DataTable userTables = null;
            string[] restrictions = new string[4];
            restrictions[3] = "TABLE";
            userTables = connect.Con.GetSchema("tables", restrictions);
            DataTableReader rd = userTables.CreateDataReader();

            while (rd.Read())
            {
                source.Add(rd.GetString(2));
            }

            return source;
                
           
        }


    }
}
