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
            this.labelSearch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNewTable
            // 
            this.labelNewTable.AutoSize = true;
            this.labelNewTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewTable.Location = new System.Drawing.Point(321, 243);
            this.labelNewTable.Name = "labelNewTable";
            this.labelNewTable.Size = new System.Drawing.Size(221, 39);
            this.labelNewTable.TabIndex = 0;
            this.labelNewTable.Text = "Neue Tabelle";
            this.labelNewTable.Click += new System.EventHandler(this.labelNewTable_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(748, 344);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(114, 39);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Suche";
            // 
            // FormMainView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1318, 631);
            this.ControlBox = false;
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.labelNewTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMainView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormNewTables";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNewTable;
        private System.Windows.Forms.Label labelSearch;
    }
}