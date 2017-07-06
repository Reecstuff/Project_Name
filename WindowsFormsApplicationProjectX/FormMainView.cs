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
        Search s;
        public FormMainView(FormMain fm)
        {
            InitializeComponent();
            m = fm;
            s = new Search();

        }

        private void labelNewTable_Click(object sender, EventArgs e)
        {
            m.newTable();
        }

        public void refreshSearch()
        {
            textBoxSearch.AutoCompleteCustomSource = s.fillSource();
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
            searchComplete();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            searchComplete();
        }

        private void searchComplete()
        {
            m.Elements(textBoxSearch.Text.ToString());
        }
    }
}
