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
    public partial class Tag : Form
    {
        RefrencesDDOOCPDataSetTableAdapters.TagTableAdapter tt;
        public Tag()
        {
            InitializeComponent();
        }

        private void Tag_Load(object sender, EventArgs e)
        {
            loadData();
            UserIDtextBox.Text = Login.LoginID;
            
        }
        public void loadData()
        {
            try
            {
                tt = new RefrencesDDOOCPDataSetTableAdapters.TagTableAdapter();
                dgvTag.DataSource = tt.GetData().CopyToDataTable();
            }
            catch (Exception)
            {
                this.Show();

            }
        }
        private void Addbutton_Click(object sender, EventArgs e)
        {
            string TagID = TagIDtextBox.Text;
            string TagName = TagNametextBox.Text;
            string UserID = UserIDtextBox.Text;
            string CreateDate = dateTimePicker.Text;

            tt = new RefrencesDDOOCPDataSetTableAdapters.TagTableAdapter();
            tt.InsertQuery(TagID, TagName, UserID,CreateDate);
            MessageBox.Show("Tag Added Successfully");
            Clear();
            loadData();


        }
        public void Clear()
        {
            TagIDtextBox.Text = "";
            TagNametextBox.Text = "";
            UserIDtextBox.Text = "";
            dateTimePicker.Text = "";

        }


        private void Editbutton_Click(object sender, EventArgs e)
        {
            tt = new RefrencesDDOOCPDataSetTableAdapters.TagTableAdapter();
            tt.UpdateTag(TagNametextBox.Text ,dateTimePicker.Text,UserIDtextBox.Text);
            MessageBox.Show("Data updates successfully.");
            try
            {
                if (TagNametextBox.Text == "")
                {
                    MessageBox.Show("Enter TagName");
                }

            }
            catch (Exception)
            {
            }
            Clear();
            loadData();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            
             string TagID = TagIDtextBox.Text;
            tt = new RefrencesDDOOCPDataSetTableAdapters.TagTableAdapter();
            tt.DeleteTag(TagID);
             MessageBox.Show("data deleted successfully.");
            Clear();
            loadData();
        }
 
        private void Backbutton_Click(object sender, EventArgs e)
        {
            Mainmenu mn = new Mainmenu();
            mn.Show();
            this.Hide();
        }

        private void Backbutton_Click_1(object sender, EventArgs e)
        {
            Mainmenu mn = new Mainmenu();
            mn.Show();
            this.Hide();
        }

        private void dgvTag_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvTag.CurrentRow.Index;
            TagIDtextBox.Text = dgvTag[0, row].Value.ToString();
            TagNametextBox.Text = dgvTag[1, row].Value.ToString();
            UserIDtextBox.Text = dgvTag[2, row].Value.ToString();
            dateTimePicker.Value = Convert.ToDateTime(dgvTag[3, row].Value);
        }

      
    }
}
