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
    public partial class FormElements : Form
    {
        FormMain m;
        string table;
        public FormElements(FormMain f)
        {
            InitializeComponent();
            m = f;
            table = null;
        }

        public void loadingView(DataSet ds, string t)
        {
            this.table = t;
            dataGridView.DataSource = null;
            dataGridView.DataSource = ds;
            dataGridView.DataMember = table;
            if(dataGridView.DataSource != null)
            {
                dataGridView.Columns[0].Visible = false;
            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            m.mainView();
            update();
        }

        private void update()
        {         
            m.updateDatabase(table);
        }
    }
}
