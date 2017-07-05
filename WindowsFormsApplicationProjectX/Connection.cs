﻿using System;
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
            adapter = new OleDbDataAdapter("SELECT * FROM "+table, Con);
            ds = new DataSet();
            adapter.Fill(ds, table);
            adapter.Dispose();
            return ds;
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
    }
}
