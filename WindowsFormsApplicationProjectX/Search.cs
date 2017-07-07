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
        
        public Search()
        {         
            
            connect = Connection.getConnection();
        
        }

        public AutoCompleteStringCollection fillSource()//Quelle für Suchfeld wird eingefügt
        {

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
