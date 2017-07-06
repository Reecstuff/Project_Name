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
            //StringBuilder s = new StringBuilder();
            //StringBuilder b = new StringBuilder();
            //string [] columnNames = new string[dataGridView.ColumnCount+1];
            //string[] values = new string[dataGridView.ColumnCount + 1];
            //int i = 0;
            //s.Append("INSERT into " + table + "(");
            //b.Append(") VALUES (");

            //for(i = 1; dataGridView.ColumnCount > i; i++)
            //{
            //    if(i == dataGridView.ColumnCount-1)
            //    {
            //        s.Append(dataGridView.Columns[i].Name);
            //        b.Append(i.ToString() + ")");
            //    }

            //    else
            //    {
            //        s.Append(dataGridView.Columns[i].Name + ", ");
            //        b.Append(i.ToString() + ", ");
            //    }

            //    columnNames[i - 1] = dataGridView.Columns[i].Name;
            //    values = dataGridView.
            //}

            //s.Append(b.ToString());

            //m.updateDatabase(s.ToString(), columnNames);

            m.updateDatabase(table);
        }
    }
}
