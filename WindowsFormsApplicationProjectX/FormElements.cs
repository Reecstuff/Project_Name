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

        public void loadingView(DataSet ds, string t)//DataGridView wird mit der Tabelle geladen
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

        private void DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {

            if (anError.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Fremdschlüssel ist nicht existent");
            }
            if (anError.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            {
                MessageBox.Show("Cell change");
            }
            if (anError.Context == DataGridViewDataErrorContexts.Parsing)
            {
                MessageBox.Show("parsing error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.LeaveControl)
            {
                MessageBox.Show("leave control error");
            }

            if ((anError.Exception) is ConstraintException)
            {
                DataGridView view = (DataGridView)sender;
                view.Rows[anError.RowIndex].ErrorText = "an error";
                view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "an error";

                anError.ThrowException = false;
            }


        }
    }
}
