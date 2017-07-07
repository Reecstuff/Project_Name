using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationProjectX
{
    public partial class FormMain : Form
    {
        //WindowsForms anlegen
        FormMainView m;
        FormNewTable nt;
        FormElements ne;
        Connection con;
        public FormMain()
        {
            //Initializierung
            InitializeComponent();

            con = new Connection();
            m = new FormMainView(this);
            nt = new FormNewTable(this);
            ne = new FormElements(this);
            //MdiParent zuweisen
            m.MdiParent = this;
            nt.MdiParent = this;
            ne.MdiParent = this;
            //Zum ausfüllen des Parentobjekts
            m.Dock = DockStyle.Fill;
            nt.Dock = DockStyle.Fill;
            ne.Dock = DockStyle.Fill;
            
            m.Show();
            m.refreshSearch();
        }

        public void newTable()
        {
            ActiveMdiChild.Hide();
            nt.Show();
        }

        public void mainView()
        {
            ActiveMdiChild.Hide();
            m.Show();
            m.refreshSearch();
        }

        public void Elements(string table)
        {
            ActiveMdiChild.Hide();
            ne.Show();
            ne.loadingView(con.fillDataGridView(table),table);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.close();
        }

        public void updateDatabase(string s)
        {
            con.updateDatabase(s);
        }

        public void refreshDatabase()
        {
            con.close();
            con.connect();
        }
    }
}
