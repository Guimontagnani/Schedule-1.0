namespace Schedule
{
    partial class All
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
            this.components = new System.ComponentModel.Container();
            this.scheduleDataSet1 = new Schedule.scheduleDataSet();
            this.cadastroTableAdapter1 = new Schedule.scheduleDataSetTableAdapters.cadastroTableAdapter();
            this.data_consulta = new System.Windows.Forms.DataGridView();
            this.scheduleDataSet11 = new Schedule.scheduleDataSet1();
            this.cadastroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroTableAdapter = new Schedule.scheduleDataSet1TableAdapters.cadastroTableAdapter();
            this.codDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_contacts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_consulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // scheduleDataSet1
            // 
            this.scheduleDataSet1.DataSetName = "scheduleDataSet";
            this.scheduleDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastroTableAdapter1
            // 
            this.cadastroTableAdapter1.ClearBeforeFill = true;
            // 
            // data_consulta
            // 
            this.data_consulta.AutoGenerateColumns = false;
            this.data_consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_consulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.data_consulta.DataSource = this.cadastroBindingSource;
            this.data_consulta.Location = new System.Drawing.Point(2, 38);
            this.data_consulta.Name = "data_consulta";
            this.data_consulta.Size = new System.Drawing.Size(469, 144);
            this.data_consulta.TabIndex = 0;
            // 
            // scheduleDataSet11
            // 
            this.scheduleDataSet11.DataSetName = "scheduleDataSet1";
            this.scheduleDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastroBindingSource
            // 
            this.cadastroBindingSource.DataMember = "cadastro";
            this.cadastroBindingSource.DataSource = this.scheduleDataSet11;
            // 
            // cadastroTableAdapter
            // 
            this.cadastroTableAdapter.ClearBeforeFill = true;
            // 
            // codDataGridViewTextBoxColumn
            // 
            this.codDataGridViewTextBoxColumn.DataPropertyName = "cod";
            this.codDataGridViewTextBoxColumn.HeaderText = "cod";
            this.codDataGridViewTextBoxColumn.Name = "codDataGridViewTextBoxColumn";
            this.codDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // lbl_contacts
            // 
            this.lbl_contacts.AutoSize = true;
            this.lbl_contacts.Font = new System.Drawing.Font("Helvetica LT Std Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contacts.Location = new System.Drawing.Point(74, 9);
            this.lbl_contacts.Name = "lbl_contacts";
            this.lbl_contacts.Size = new System.Drawing.Size(217, 21);
            this.lbl_contacts.TabIndex = 1;
            this.lbl_contacts.Text = "All contacts Registered";
            // 
            // All
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 233);
            this.Controls.Add(this.lbl_contacts);
            this.Controls.Add(this.data_consulta);
            this.Name = "All";
            this.Text = "All";
            this.Load += new System.EventHandler(this.All_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_consulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private scheduleDataSet scheduleDataSet1;
        private scheduleDataSetTableAdapters.cadastroTableAdapter cadastroTableAdapter1;
        private System.Windows.Forms.DataGridView data_consulta;
        private scheduleDataSet1 scheduleDataSet11;
        private System.Windows.Forms.BindingSource cadastroBindingSource;
        private scheduleDataSet1TableAdapters.cadastroTableAdapter cadastroTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl_contacts;

    }
}