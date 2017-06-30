using System;
using System.Collections.Generic;
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
        }
    }
}
