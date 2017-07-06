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

        private void pictureBoxBack_Click(object sender, EventArgs e)//Beim Drücken auf den Zurück-Pfeil kehren Sie zurück in den Suchbereich
        {
            m.mainView();
        }

        private void pictureBoxTabellenname_Click(object sender, EventArgs e)
        {
            if(!(textBoxTabellenname.Text.Equals("")))
            {
                labelSpalte1.Visible = true;
                textBoxSpalte1.Visible = true;
                pictureBoxSpalte1.Visible = true;
                te = new TabelleErstellen(textBoxTabellenname.Text);
            }
            
        }

        private void pictureBoxSpalte1_Click(object sender, EventArgs e)
        {
            if (!(textBoxSpalte1.Text.Equals("")))
            {
                labelSpalte2.Visible = true;
                textBoxSpalte2.Visible = true;
                pictureBoxSpalte2.Visible = true;
                buttonTabelleErstellen.Visible = true;
                te.Spalte1 = textBoxSpalte1.Text;
            }            
        }

        private void pictureBoxSpalte2_Click(object sender, EventArgs e)
        {
            if (!(textBoxSpalte2.Text.Equals("")))
            {
                labelSpalte3.Visible = true;
                textBoxSpalte3.Visible = true;
                pictureBoxSpalte3.Visible = true;
                te.Spalte2 = textBoxSpalte2.Text;
            }            
        }

        private void pictureBoxSpalte3_Click(object sender, EventArgs e)
        {
            if (!(textBoxSpalte3.Text.Equals("")))
            {
                labelSpalte4.Visible = true;
                textBoxSpalte4.Visible = true;
                pictureBoxSpalte4.Visible = true;
                te.Spalte3 = textBoxSpalte3.Text;
            }            
        }

        private void pictureBoxSpalte4_Click(object sender, EventArgs e)
        {
            if (!(textBoxSpalte4.Text.Equals("")))
            {
                labelSpalte5.Visible = true;
                textBoxSpalte5.Visible = true;
                pictureBoxSpalte5.Visible = true;
                te.Spalte4 = textBoxSpalte4.Text;
            }            
        }

        private void pictureBoxSpalte5_Click(object sender, EventArgs e)
        {
            if (!(textBoxSpalte5.Text.Equals("")))
            {
                te.Spalte5 = textBoxSpalte5.Text;
            }                
        }

        private void buttonTabelleErstellen_Click(object sender, EventArgs e)
        {
            te.erstellenTabelle();//die Tabelle wird erstellt und in der Datenbank gespeichert
            m.Elements(te.Tabellenname);
        }
    }
}
