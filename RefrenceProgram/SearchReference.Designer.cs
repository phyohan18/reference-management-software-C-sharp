namespace RefrenceProgram
{
    partial class SearchReference
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchReference));
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.searchbytittle = new System.Windows.Forms.RadioButton();
            this.searchbyauthor = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.searchbtm = new System.Windows.Forms.Button();
            this.showallbtm = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.formatcombobox = new System.Windows.Forms.ComboBox();
            this.formatbtm = new System.Windows.Forms.Button();
            this.backbtm = new System.Windows.Forms.Button();
            this.exportbtm = new System.Windows.Forms.Button();
            this.dataRefBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.refrencesDDOOCPDataSet = new RefrenceProgram.RefrencesDDOOCPDataSet();
            this.dataRefTableAdapter = new RefrenceProgram.RefrencesDDOOCPDataSetTableAdapters.DataRefTableAdapter();
            this.refrencesDDOOCPDataSet1 = new RefrenceProgram.RefrencesDDOOCPDataSet();
            this.lstFormat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataRefBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refrencesDDOOCPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refrencesDDOOCPDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSearch
            // 
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(9, 124);
            this.dgvSearch.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.RowTemplate.Height = 24;
            this.dgvSearch.Size = new System.Drawing.Size(800, 219);
            this.dgvSearch.TabIndex = 0;
            // 
            // searchbytittle
            // 
            this.searchbytittle.AutoSize = true;
            this.searchbytittle.Location = new System.Drawing.Point(30, 89);
            this.searchbytittle.Margin = new System.Windows.Forms.Padding(2);
            this.searchbytittle.Name = "searchbytittle";
            this.searchbytittle.Size = new System.Drawing.Size(95, 17);
            this.searchbytittle.TabIndex = 1;
            this.searchbytittle.TabStop = true;
            this.searchbytittle.Text = "Search by tittle";
            this.searchbytittle.UseVisualStyleBackColor = true;
            // 
            // searchbyauthor
            // 
            this.searchbyauthor.AutoSize = true;
            this.searchbyauthor.Location = new System.Drawing.Point(127, 89);
            this.searchbyauthor.Margin = new System.Windows.Forms.Padding(2);
            this.searchbyauthor.Name = "searchbyauthor";
            this.searchbyauthor.Size = new System.Drawing.Size(109, 17);
            this.searchbyauthor.TabIndex = 2;
            this.searchbyauthor.TabStop = true;
            this.searchbyauthor.Text = "Search by  author";
            this.searchbyauthor.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(374, 89);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(76, 20);
            this.txtSearch.TabIndex = 4;
            // 
            // searchbtm
            // 
            this.searchbtm.Image = ((System.Drawing.Image)(resources.GetObject("searchbtm.Image")));
            this.searchbtm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchbtm.Location = new System.Drawing.Point(460, 72);
            this.searchbtm.Margin = new System.Windows.Forms.Padding(2);
            this.searchbtm.Name = "searchbtm";
            this.searchbtm.Size = new System.Drawing.Size(100, 35);
            this.searchbtm.TabIndex = 5;
            this.searchbtm.Text = "   Search";
            this.searchbtm.UseVisualStyleBackColor = true;
            this.searchbtm.Click += new System.EventHandler(this.btm1_Click);
            // 
            // showallbtm
            // 
            this.showallbtm.Image = ((System.Drawing.Image)(resources.GetObject("showallbtm.Image")));
            this.showallbtm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showallbtm.Location = new System.Drawing.Point(572, 72);
            this.showallbtm.Margin = new System.Windows.Forms.Padding(2);
            this.showallbtm.Name = "showallbtm";
            this.showallbtm.Size = new System.Drawing.Size(100, 35);
            this.showallbtm.TabIndex = 6;
            this.showallbtm.Text = "   Show all";
            this.showallbtm.UseVisualStyleBackColor = true;
            this.showallbtm.Click += new System.EventHandler(this.btm2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(872, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 394);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Style";
            // 
            // formatcombobox
            // 
            this.formatcombobox.FormattingEnabled = true;
            this.formatcombobox.Items.AddRange(new object[] {
            "APA",
            "Harvard",
            "Chicago"});
            this.formatcombobox.Location = new System.Drawing.Point(79, 394);
            this.formatcombobox.Margin = new System.Windows.Forms.Padding(2);
            this.formatcombobox.Name = "formatcombobox";
            this.formatcombobox.Size = new System.Drawing.Size(130, 21);
            this.formatcombobox.TabIndex = 9;
            // 
            // formatbtm
            // 
            this.formatbtm.Image = ((System.Drawing.Image)(resources.GetObject("formatbtm.Image")));
            this.formatbtm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.formatbtm.Location = new System.Drawing.Point(238, 394);
            this.formatbtm.Margin = new System.Windows.Forms.Padding(2);
            this.formatbtm.Name = "formatbtm";
            this.formatbtm.Size = new System.Drawing.Size(106, 32);
            this.formatbtm.TabIndex = 10;
            this.formatbtm.Text = "     Format";
            this.formatbtm.UseVisualStyleBackColor = true;
            this.formatbtm.Click += new System.EventHandler(this.formatbtm_Click);
            // 
            // backbtm
            // 
            this.backbtm.Image = ((System.Drawing.Image)(resources.GetObject("backbtm.Image")));
            this.backbtm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backbtm.Location = new System.Drawing.Point(762, 0);
            this.backbtm.Margin = new System.Windows.Forms.Padding(2);
            this.backbtm.Name = "backbtm";
            this.backbtm.Size = new System.Drawing.Size(110, 57);
            this.backbtm.TabIndex = 12;
            this.backbtm.Text = "Back";
            this.backbtm.UseVisualStyleBackColor = true;
            this.backbtm.Click += new System.EventHandler(this.Back_Click);
            // 
            // exportbtm
            // 
            this.exportbtm.Image = ((System.Drawing.Image)(resources.GetObject("exportbtm.Image")));
            this.exportbtm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exportbtm.Location = new System.Drawing.Point(238, 442);
            this.exportbtm.Name = "exportbtm";
            this.exportbtm.Size = new System.Drawing.Size(106, 33);
            this.exportbtm.TabIndex = 14;
            this.exportbtm.Text = "   Export";
            this.exportbtm.UseVisualStyleBackColor = true;
            this.exportbtm.Click += new System.EventHandler(this.exportbtm_Click);
            // 
            // dataRefBindingSource
            // 
            this.dataRefBindingSource.DataMember = "DataRef";
            this.dataRefBindingSource.DataSource = this.refrencesDDOOCPDataSet;
            // 
            // refrencesDDOOCPDataSet
            // 
            this.refrencesDDOOCPDataSet.DataSetName = "RefrencesDDOOCPDataSet";
            this.refrencesDDOOCPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataRefTableAdapter
            // 
            this.dataRefTableAdapter.ClearBeforeFill = true;
            // 
            // refrencesDDOOCPDataSet1
            // 
            this.refrencesDDOOCPDataSet1.DataSetName = "RefrencesDDOOCPDataSet";
            this.refrencesDDOOCPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lstFormat
            // 
            this.lstFormat.Location = new System.Drawing.Point(460, 391);
            this.lstFormat.Multiline = true;
            this.lstFormat.Name = "lstFormat";
            this.lstFormat.Size = new System.Drawing.Size(212, 110);
            this.lstFormat.TabIndex = 15;
            // 
            // SearchReference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(872, 540);
            this.Controls.Add(this.lstFormat);
            this.Controls.Add(this.exportbtm);
            this.Controls.Add(this.backbtm);
            this.Controls.Add(this.formatbtm);
            this.Controls.Add(this.formatcombobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showallbtm);
            this.Controls.Add(this.searchbtm);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.searchbyauthor);
            this.Controls.Add(this.searchbytittle);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SearchReference";
            this.Text = "SearchReference";
            this.Load += new System.EventHandler(this.SerchRefence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataRefBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refrencesDDOOCPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refrencesDDOOCPDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.RadioButton searchbytittle;
        private System.Windows.Forms.RadioButton searchbyauthor;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button searchbtm;
        private System.Windows.Forms.Button showallbtm;
        private RefrencesDDOOCPDataSet refrencesDDOOCPDataSet;
        private System.Windows.Forms.BindingSource dataRefBindingSource;
        private RefrencesDDOOCPDataSetTableAdapters.DataRefTableAdapter dataRefTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox formatcombobox;
        private System.Windows.Forms.Button formatbtm;
        private System.Windows.Forms.Button backbtm;
        private System.Windows.Forms.Button exportbtm;
        private RefrencesDDOOCPDataSet refrencesDDOOCPDataSet1;
        private System.Windows.Forms.TextBox lstFormat;
    }
}