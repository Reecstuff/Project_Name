namespace WindowsFormsApplicationProjectX
{
    partial class FormMainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelNewTable = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNewTable
            // 
            this.labelNewTable.AutoSize = true;
            this.labelNewTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewTable.Location = new System.Drawing.Point(88, 402);
            this.labelNewTable.Name = "labelNewTable";
            this.labelNewTable.Size = new System.Drawing.Size(221, 39);
            this.labelNewTable.TabIndex = 0;
            this.labelNewTable.Text = "Neue Tabelle";
            this.labelNewTable.Click += new System.EventHandler(this.labelNewTable_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(363, 259);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(515, 45);
            this.textBoxSearch.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(487, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 82);
            this.label1.TabIndex = 4;
            this.label1.Text = "Goggle";
            // 
            // FormMainView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1318, 631);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelNewTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMainView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormNewTables";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNewTable;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
    }
}