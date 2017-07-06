using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplicationProjectX
{
    class TabelleErstellen
    {
        private String tabellenname;
        private String spalte1 = null;
        private String spalte2 = null;
        private String spalte3 = null;
        private String spalte4 = null;
        private String spalte5 = null;
        Connection connect;
        OleDbCommand command = new OleDbCommand();


        public string Tabellenname
        {
            get
            {
                return tabellenname;
            }

            set
            {
                tabellenname = value;
            }
        }

        public string Spalte1
        {
            get
            {
                return spalte1;
            }

            set
            {
                spalte1 = value;
            }
        }

        public string Spalte2
        {
            get
            {
                return spalte2;
            }

            set
            {
                spalte2 = value;
            }
        }

        public string Spalte3
        {
            get
            {
                return spalte3;
            }

            set
            {
                spalte3 = value;
            }
        }

        public string Spalte4
        {
            get
            {
                return spalte4;
            }

            set
            {
                spalte4 = value;
            }
        }

        public string Spalte5
        {
            get
            {
                return spalte5;
            }

            set
            {
                spalte5 = value;
            }
        }

        public TabelleErstellen(String Tabellenname)
        {
            this.Tabellenname = Tabellenname;
            connect = Connection.getConnection();
        }

        public void erstellenTabelle()
        {
            command = connect.Con.CreateCommand();
            command.CommandText = erstelleBefehl();//der SQL-Befehl zum Erstellen der Tabelle
            command.ExecuteNonQuery();
        }

        public String erstelleBefehl()
        {
            StringBuilder s = new StringBuilder();
            s.Append("CREATE TABLE " + tabellenname + " (");
            if(spalte1 != null)
            {
                s.Append(spalte1 + " VARCHAR(25),");
            }
            if (spalte2 != null)
            {
                s.Append(spalte2 + " VARCHAR(25),");
            }
            if (spalte3 != null)
            {
                s.Append(spalte3 + " VARCHAR(25),");
            }
            if (spalte4 != null)
            {
                s.Append(spalte4 + " VARCHAR(25),");
            }
            if (spalte5 != null)
            {
                s.Append(spalte5 + " VARCHAR(25),");
            }
            s.Remove(s.Length-1, 1);
            s.Append(");");
            
            return s.ToString();
        }
    }
}
