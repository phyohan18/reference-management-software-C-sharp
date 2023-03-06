namespace RefrenceProgram
{
    partial class Searchbytag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Searchbytag));
            this.cboTag = new System.Windows.Forms.ComboBox();
            this.dgvtag = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btmback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTag
            // 
            this.cboTag.FormattingEnabled = true;
            this.cboTag.Location = new System.Drawing.Point(6, 16);
            this.cboTag.Margin = new System.Windows.Forms.Padding(2);
            this.cboTag.Name = "cboTag";
            this.cboTag.Size = new System.Drawing.Size(566, 21);
            this.cboTag.TabIndex = 0;
            this.cboTag.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dgvtag
            // 
            this.dgvtag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtag.Location = new System.Drawing.Point(18, 54);
            this.dgvtag.Margin = new System.Windows.Forms.Padding(2);
            this.dgvtag.Name = "dgvtag";
            this.dgvtag.RowTemplate.Height = 24;
            this.dgvtag.Size = new System.Drawing.Size(545, 381);
            this.dgvtag.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(579, 15);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(33, 20);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.Visible = false;
            // 
            // btmback
            // 
            this.btmback.Image = ((System.Drawing.Image)(resources.GetObject("btmback.Image")));
            this.btmback.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmback.Location = new System.Drawing.Point(579, 10);
            this.btmback.Margin = new System.Windows.Forms.Padding(2);
            this.btmback.Name = "btmback";
            this.btmback.Size = new System.Drawing.Size(77, 68);
            this.btmback.TabIndex = 3;
            this.btmback.Text = "   Back";
            this.btmback.UseVisualStyleBackColor = true;
            this.btmback.Click += new System.EventHandler(this.btmback_Click);
            // 
            // Searchbytag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(662, 449);
            this.Controls.Add(this.btmback);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dgvtag);
            this.Controls.Add(this.cboTag);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Searchbytag";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Searchbytag";
            this.Load += new System.EventHandler(this.searchbytag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTag;
        private System.Windows.Forms.DataGridView dgvtag;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btmback;
    }
}