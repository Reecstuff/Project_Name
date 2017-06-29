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
        FormNewElements ne;
        public FormMain()
        {
            //Initializierung
            InitializeComponent();

            m = new FormMainView(this);
            nt = new FormNewTable(this);
            ne = new FormNewElements(this);
            //MdiParent zuweisen
            m.MdiParent = this;
            nt.MdiParent = this;
            ne.MdiParent = this;

            m.Dock = DockStyle.Fill;
            nt.Dock = DockStyle.Fill;
            ne.Dock = DockStyle.Fill;

            m.Show();
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
        }

        public void newElements()
        {
            ActiveMdiChild.Hide();
            ne.Show();
        }

    }
}
