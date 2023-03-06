using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrenceProgram
{
    public partial class Searchbytag : Form
    {
        RefrencesDDOOCPDataSetTableAdapters.TagTableAdapter tt;
        RefrencesDDOOCPDataSetTableAdapters.DataRefTableAdapter dt;
        public Searchbytag()
        {
            InitializeComponent();
        }

        private void searchbytag_Load(object sender, EventArgs e)
        {

            
                tt = new RefrencesDDOOCPDataSetTableAdapters.TagTableAdapter();
                dataGridView2.DataSource = tt.GetData().CopyToDataTable();
                int rows = dataGridView2.RowCount;
                for (int i = 0; i < rows - 1; i++)
                {
                    string tagname = dataGridView2[1, i].Value.ToString();
                    cboTag.Items.Add(tagname);
                }
            
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = new RefrencesDDOOCPDataSetTableAdapters.DataRefTableAdapter();
            string tagname = cboTag.SelectedItem.ToString();
            dgvtag.DataSource = dt.SearchTag(Login.LoginID, tagname);
        }

        private void btmback_Click(object sender, EventArgs e)
        {
            Mainmenu mn = new Mainmenu();
            mn.Show();
            this.Hide();
        }
    }
}
