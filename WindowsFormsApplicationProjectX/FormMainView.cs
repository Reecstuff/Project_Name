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
            m.newTable();
        }

        private void richTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(richTextBox.Focused)
            {
                if (e.KeyCode == Keys.Down)
                {
                    listBox.SetSelected(0, true);
                }
            }
        }

        private void listBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (listBox.Focused)
            {
                switch (e.KeyCode)
                {
                    case Keys.Down:
                        listBox.SetSelected(1, true);
                        break;
                    case Keys.Up:
                        if (listBox.Items.Count == listBox.TopIndex)
                        {
                            richTextBox.Select();
                        }
                        else
                        {
                            listBox.SetSelected(0, true);
                        }
                        break;
                }
            }
        }
    }
}
