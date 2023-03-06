namespace RefrenceProgram
{
    partial class Tag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tag));
            this.Backbutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Editbutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.TagIDtextBox = new System.Windows.Forms.TextBox();
            this.TagNametextBox = new System.Windows.Forms.TextBox();
            this.UserIDtextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.refrencesDDOOCPDataSet = new RefrenceProgram.RefrencesDDOOCPDataSet();
            this.tagTableAdapter = new RefrenceProgram.RefrencesDDOOCPDataSetTableAdapters.TagTableAdapter();
            this.dgvTag = new System.Windows.Forms.DataGridView();
            this.tagIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refrencesDDOOCPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTag)).BeginInit();
            this.SuspendLayout();
            // 
            // Backbutton
            // 
            this.Backbutton.Image = ((System.Drawing.Image)(resources.GetObject("Backbutton.Image")));
            this.Backbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Backbutton.Location = new System.Drawing.Point(425, 238);
            this.Backbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(109, 43);
            this.Backbutton.TabIndex = 0;
            this.Backbutton.Text = "   Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click_1);
            // 
            // Addbutton
            // 
            this.Addbutton.Image = ((System.Drawing.Image)(resources.GetObject("Addbutton.Image")));
            this.Addbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Addbutton.Location = new System.Drawing.Point(28, 238);
            this.Addbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(109, 42);
            this.Addbutton.TabIndex = 1;
            this.Addbutton.Text = "   Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Editbutton
            // 
            this.Editbutton.Image = ((System.Drawing.Image)(resources.GetObject("Editbutton.Image")));
            this.Editbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Editbutton.Location = new System.Drawing.Point(157, 238);
            this.Editbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(109, 42);
            this.Editbutton.TabIndex = 2;
            this.Editbutton.Text = "   Edit";
            this.Editbutton.UseVisualStyleBackColor = true;
            this.Editbutton.Click += new System.EventHandler(this.Editbutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Image = ((System.Drawing.Image)(resources.GetObject("Deletebutton.Image")));
            this.Deletebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Deletebutton.Location = new System.Drawing.Point(291, 238);
            this.Deletebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(109, 42);
            this.Deletebutton.TabIndex = 3;
            this.Deletebutton.Text = "   Delete";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(17, 15);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(46, 17);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "TagID";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(17, 58);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(74, 17);
            this.lbl2.TabIndex = 6;
            this.lbl2.Text = "Tag Name";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(17, 100);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(51, 17);
            this.lbl3.TabIndex = 7;
            this.lbl3.Text = "UserID";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(17, 143);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(80, 17);
            this.lbl4.TabIndex = 8;
            this.lbl4.Text = "CreateDate";
            // 
            // TagIDtextBox
            // 
            this.TagIDtextBox.Location = new System.Drawing.Point(168, 11);
            this.TagIDtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TagIDtextBox.Name = "TagIDtextBox";
            this.TagIDtextBox.Size = new System.Drawing.Size(175, 22);
            this.TagIDtextBox.TabIndex = 9;
            // 
            // TagNametextBox
            // 
            this.TagNametextBox.Location = new System.Drawing.Point(168, 58);
            this.TagNametextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TagNametextBox.Name = "TagNametextBox";
            this.TagNametextBox.Size = new System.Drawing.Size(175, 22);
            this.TagNametextBox.TabIndex = 10;
            // 
            // UserIDtextBox
            // 
            this.UserIDtextBox.Location = new System.Drawing.Point(168, 100);
            this.UserIDtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserIDtextBox.Name = "UserIDtextBox";
            this.UserIDtextBox.Size = new System.Drawing.Size(175, 22);
            this.UserIDtextBox.TabIndex = 11;
           
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(169, 145);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(171, 22);
            this.dateTimePicker.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(408, 48);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 159);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.UserIDtextBox);
            this.groupBox1.Controls.Add(this.TagNametextBox);
            this.groupBox1.Controls.Add(this.TagIDtextBox);
            this.groupBox1.Controls.Add(this.lbl4);
            this.groupBox1.Controls.Add(this.lbl3);
            this.groupBox1.Controls.Add(this.lbl2);
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Location = new System.Drawing.Point(21, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(377, 181);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tag";
            // 
            // tagBindingSource
            // 
            this.tagBindingSource.DataMember = "Tag";
            this.tagBindingSource.DataSource = this.refrencesDDOOCPDataSet;
            // 
            // refrencesDDOOCPDataSet
            // 
            this.refrencesDDOOCPDataSet.DataSetName = "RefrencesDDOOCPDataSet";
            this.refrencesDDOOCPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tagTableAdapter
            // 
            this.tagTableAdapter.ClearBeforeFill = true;
            // 
            // dgvTag
            // 
            this.dgvTag.AutoGenerateColumns = false;
            this.dgvTag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTag.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tagIDDataGridViewTextBoxColumn,
            this.tagNameDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn});
            this.dgvTag.DataSource = this.tagBindingSource;
            this.dgvTag.Location = new System.Drawing.Point(21, 301);
            this.dgvTag.Name = "dgvTag";
            this.dgvTag.RowTemplate.Height = 24;
            this.dgvTag.Size = new System.Drawing.Size(570, 150);
            this.dgvTag.TabIndex = 13;
            this.dgvTag.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTag_CellClick);
            // 
            // tagIDDataGridViewTextBoxColumn
            // 
            this.tagIDDataGridViewTextBoxColumn.DataPropertyName = "TagID";
            this.tagIDDataGridViewTextBoxColumn.HeaderText = "TagID";
            this.tagIDDataGridViewTextBoxColumn.Name = "tagIDDataGridViewTextBoxColumn";
            // 
            // tagNameDataGridViewTextBoxColumn
            // 
            this.tagNameDataGridViewTextBoxColumn.DataPropertyName = "TagName";
            this.tagNameDataGridViewTextBoxColumn.HeaderText = "TagName";
            this.tagNameDataGridViewTextBoxColumn.Name = "tagNameDataGridViewTextBoxColumn";
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.HeaderText = "CreateDate";
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            // 
            // Tag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(624, 463);
            this.Controls.Add(this.dgvTag);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Editbutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.Backbutton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Tag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tag";
            this.Load += new System.EventHandler(this.Tag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tagBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refrencesDDOOCPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTag)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Editbutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox TagIDtextBox;
        private System.Windows.Forms.TextBox TagNametextBox;
        private System.Windows.Forms.TextBox UserIDtextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.BindingSource tagBindingSource;
        private RefrencesDDOOCPDataSet refrencesDDOOCPDataSet;
        private RefrencesDDOOCPDataSetTableAdapters.TagTableAdapter tagTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvTag;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
    }
}