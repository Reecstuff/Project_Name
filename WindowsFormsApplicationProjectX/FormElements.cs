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
        public FormElements(FormMain f)
        {
            InitializeComponent();
            m = f;       
        }

        public void loadingView(DataSet ds, string table)
        {
            dataGridView.DataSource = ds;
            dataGridView.DataMember = "";
            dataGridView.Columns[0].Visible = false;
        }
    }
}
