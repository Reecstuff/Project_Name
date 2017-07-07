using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace WindowsFormsApplicationProjectX
{
    public class Connection
    {
        static Connection instance = null;
        OleDbConnection con;
        OleDbDataAdapter adapter;
        DataSet ds;
        public Connection()
        {
            connect();
        }

        public void connect()//Connection aufbauen zur Datenbank
        {
            con = new OleDbConnection();
            con.ConnectionString = Properties.Settings.Default.DbPath;
            con.Open();
        }

        public void close()//Datenbank schließen
        {
            con.Close();
        }

        public DataSet fillDataGridView(string table)//GridView befüllen
        {
            if (!table.Equals(""))
            {
                adapter = new OleDbDataAdapter("SELECT * FROM " + table, Con);
                ds = new DataSet();
                adapter.Fill(ds, table);
                return ds;
            }

            else
            {
                return null;
            }
        }

        public OleDbConnection Con
        {
            get
            {
                return con;
            }

            set
            {
                con = value;
            }
        }

        public static Connection getConnection()
        {
            if (instance == null)
            {
                instance = new Connection();
            }
            return instance;
        }

        public void updateDatabase(string table)//Datenbank wird mit veränderten Daten aktualisiert
        {
            
            OleDbCommandBuilder cmdBld = new OleDbCommandBuilder(adapter);
            try
            {
                adapter.DeleteCommand = cmdBld.GetDeleteCommand();
                adapter.InsertCommand = cmdBld.GetInsertCommand();
                adapter.UpdateCommand = cmdBld.GetUpdateCommand();
                adapter.Update(ds.Tables[table]);
            }
            catch(InvalidOperationException e)
            {
                insertDataBase(table);
            }
         
        }

        public void insertDataBase(string table)//Datenbank wird mit neuen Daten aus einer neu erstellten Tabelle gefüllt
        {
            OleDbCommandBuilder cmdBld = new OleDbCommandBuilder(adapter);
            adapter.InsertCommand = cmdBld.GetInsertCommand();
            adapter.Update(ds.Tables[table]);
        }
    }
}
