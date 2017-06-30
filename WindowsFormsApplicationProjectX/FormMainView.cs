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
    public partial class FormMainView : Form
    {
        FormMain m;
        public FormMainView(FormMain fm)
        {
            InitializeComponent();
            m = fm;
        }

        private void labelNewTable_Click(object sender, EventArgs e)
        {
            //m.newTable();
            m.getMDI(this);
        }
    }
}
