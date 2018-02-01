namespace Schedule
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btn_search = new System.Windows.Forms.Button();
            this.txb_name = new System.Windows.Forms.TextBox();
            this.txb_phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scheduleDataSet = new Schedule.scheduleDataSet();
            this.cadastroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroTableAdapter = new Schedule.scheduleDataSetTableAdapters.cadastroTableAdapter();
            this.btn_grid = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_able = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn_search.Font = new System.Drawing.Font("Helvetica LT Std Black", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_search.Location = new System.Drawing.Point(252, 37);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 33);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txb_name
            // 
            this.txb_name.BackColor = System.Drawing.Color.White;
            this.txb_name.Font = new System.Drawing.Font("Helvetica LT Std Cond", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_name.Location = new System.Drawing.Point(12, 37);
            this.txb_name.Name = "txb_name";
            this.txb_name.Size = new System.Drawing.Size(210, 24);
            this.txb_name.TabIndex = 1;
            // 
            // txb_phone
            // 
            this.txb_phone.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.txb_phone.Enabled = false;
            this.txb_phone.Font = new System.Drawing.Font("Helvetica LT Std Cond Blk", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_phone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txb_phone.Location = new System.Drawing.Point(12, 96);
            this.txb_phone.Name = "txb_phone";
            this.txb_phone.Size = new System.Drawing.Size(125, 24);
            this.txb_phone.TabIndex = 2;
            this.txb_phone.Text = "To insert click able";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phone";
            // 
            // scheduleDataSet
            // 
            this.scheduleDataSet.DataSetName = "scheduleDataSet";
            this.scheduleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastroBindingSource
            // 
            this.cadastroBindingSource.DataMember = "cadastro";
            this.cadastroBindingSource.DataSource = this.scheduleDataSet;
            // 
            // cadastroTableAdapter
            // 
            this.cadastroTableAdapter.ClearBeforeFill = true;
            // 
            // btn_grid
            // 
            this.btn_grid.Font = new System.Drawing.Font("Helvetica LT Std Black", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_grid.Location = new System.Drawing.Point(252, 76);
            this.btn_grid.Name = "btn_grid";
            this.btn_grid.Size = new System.Drawing.Size(75, 33);
            this.btn_grid.TabIndex = 5;
            this.btn_grid.Text = "Show All";
            this.btn_grid.UseVisualStyleBackColor = true;
            this.btn_grid.Click += new System.EventHandler(this.btn_grid_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Font = new System.Drawing.Font("Helvetica LT Std Black", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Location = new System.Drawing.Point(252, 115);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(75, 33);
            this.btn_insert.TabIndex = 6;
            this.btn_insert.Text = "INSERT";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_able
            // 
            this.btn_able.Font = new System.Drawing.Font("Helvetica LT Std Black", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_able.Location = new System.Drawing.Point(252, 154);
            this.btn_able.Name = "btn_able";
            this.btn_able.Size = new System.Drawing.Size(75, 33);
            this.btn_able.TabIndex = 7;
            this.btn_able.Text = "Able";
            this.btn_able.UseVisualStyleBackColor = true;
            this.btn_able.Click += new System.EventHandler(this.btn_able_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(339, 256);
            this.Controls.Add(this.btn_able);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_grid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_phone);
            this.Controls.Add(this.txb_name);
            this.Controls.Add(this.btn_search);
            this.DoubleBuffered = true;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scheduleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_phone;
        private scheduleDataSet scheduleDataSet;
        private System.Windows.Forms.BindingSource cadastroBindingSource;
        private scheduleDataSetTableAdapters.cadastroTableAdapter cadastroTableAdapter;
        private System.Windows.Forms.Button btn_grid;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_able;
    }
}

