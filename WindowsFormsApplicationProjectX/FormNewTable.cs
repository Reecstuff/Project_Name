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
    public partial class FormNewTable : Form
    {
        FormMain m;
        TabelleErstellen te;
        public FormNewTable(FormMain f)
        {
            InitializeComponent();
            m = f;
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxTabellenname_Click(object sender, EventArgs e)
        {
            labelSpalte1.Visible = true;
            textBoxSpalte1.Visible = true;
            pictureBoxSpalte1.Visible = true;
        }

        private void pictureBoxSpalte1_Click(object sender, EventArgs e)
        {
            labelSpalte2.Visible = true;
            textBoxSpalte2.Visible = true;
            pictureBoxSpalte2.Visible = true;
            buttonTabelleErstellen.Visible = true;
        }

        private void pictureBoxSpalte2_Click(object sender, EventArgs e)
        {
            labelSpalte3.Visible = true;
            textBoxSpalte3.Visible = true;
            pictureBoxSpalte3.Visible = true;
        }

        private void pictureBoxSpalte3_Click(object sender, EventArgs e)
        {
            labelSpalte4.Visible = true;
            textBoxSpalte4.Visible = true;
            pictureBoxSpalte4.Visible = true;
        }

        private void pictureBoxSpalte4_Click(object sender, EventArgs e)
        {
            labelSpalte5.Visible = true;
            textBoxSpalte5.Visible = true;
            pictureBoxSpalte5.Visible = true;
        }

        private void pictureBoxSpalte5_Click(object sender, EventArgs e)
        {

        }

        private void buttonTabelleErstellen_Click(object sender, EventArgs e)
        {
            te = new TabelleErstellen(textBoxTabellenname.Text);
        }
    }
}
