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
    public partial class References : Form
    {
        RefrencesDDOOCPDataSetTableAdapters.DataRefTableAdapter rd;
        RefrencesDDOOCPDataSetTableAdapters.TagRefrenceTableAdapter tr;
        RefrencesDDOOCPDataSetTableAdapters.TagTableAdapter tt;
        public References()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            txtUserID.Text = Login.LoginID;
            try
            {
                rd = new RefrencesDDOOCPDataSetTableAdapters.DataRefTableAdapter();
                dgvReference.DataSource = rd.GetData().CopyToDataTable();
                label1.Text = "Welcome " + Login.LoginUserName;
                
            }
            catch(Exception e)
            {
                this.Show();
            }
        }
        public void Clear()
        {
            txtRefID.Text = "";
            txtUserID.Text = "";
            txtReferenceType.Text = "";
            txtAuthor.Text = "";
            txtTittle.Text = "";
            txtPublishedYear.Text = "";
            txtPublishedData.Text = "";
            txtPublishedCompany.Text = "";
            txtCity.Text = "";
            txtRegion.Text = "";
            txtEdition.Text = "";
            txtPublisher.Text = "";
            txtDataAccessed.Text = "";
            txtIssue.Text = "";
            txtVolume.Text = "";
            txtNotes.Text = "";
            txtPageNumbers.Text = "";

        }
        private void btn1_Click(object sender, EventArgs e)
        {
            rd = new RefrencesDDOOCPDataSetTableAdapters.DataRefTableAdapter();
            rd.UpdateReference(txtReferenceType.Text, txtAuthor.Text, txtTittle.Text, txtPublishedYear.Text, txtPublishedData.Text, txtPublishedCompany.Text, txtCity.Text, txtRegion.Text, txtEdition.Text, txtPublisher.Text, txtDataAccessed.Text, txtIssue.Text, txtVolume.Text, txtNotes.Text, txtPageNumbers.Text, txtUserID.Text);
            MessageBox.Show("Data updates successfully.");
            Clear();
            rd = new RefrencesDDOOCPDataSetTableAdapters.DataRefTableAdapter();
            dgvReference.DataSource = rd.GetData().CopyToDataTable();
            LoadData();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string userid = txtUserID.Text;
            rd = new RefrencesDDOOCPDataSetTableAdapters.DataRefTableAdapter();
            rd.DeleteReference(userid);
            MessageBox.Show("Reference deleted successfully.");
            Clear();
            LoadData();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string RefID1 = txtRefID.Text;
            string UserID1 = txtUserID.Text;
            string ReferenceType1 = txtReferenceType.Text;
            string Author1 = txtAuthor.Text;
            string Tittle1 = txtTittle.Text;
            string PublishedYear1 = txtPublishedYear.Text;
            string PublishedDate1 = txtPublishedData.Text;
            string PublishedCompany1 = txtPublishedCompany.Text;
            string City1 = txtCity.Text;
            string Region1 = txtRegion.Text;
            string Edition1 = txtEdition.Text;
            string Publisher1 = txtPublisher.Text;
            string DataAccessed1 = txtDataAccessed.Text;
            string Issue1 = txtIssue.Text;
            string Volume1 = txtVolume.Text;
            string Notes1 = txtNotes.Text;
            string PageNumbers1 = txtPageNumbers.Text;

            rd = new RefrencesDDOOCPDataSetTableAdapters.DataRefTableAdapter();
            rd.InsertQuery(RefID1, UserID1, ReferenceType1, Author1, Tittle1, PublishedYear1, PublishedDate1, PublishedCompany1, City1, Region1, Edition1, Publisher1, DataAccessed1, Issue1, Volume1
                , Notes1, PageNumbers1);

            MessageBox.Show("Reference added successfully.");
            Clear();
            LoadData();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Mainmenu r = new Mainmenu();
            r.Show();
            this.Hide();
        }

       

        private void References_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
                tt = new RefrencesDDOOCPDataSetTableAdapters.TagTableAdapter();
                dgvtag.DataSource = tt.GetData().CopyToDataTable();
                int rows = dgvtag.RowCount;
                for (int i = 0; i < rows - 1; i++)
                {
                    string tagname = dgvtag[1, i].Value.ToString();
                    cbotag.Items.Add(tagname);
                }
            }
            catch(Exception ex)
            {
                this.Show();

            }

        }

        private void dgvReference_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int row = dgvReference.CurrentRow.Index;
            txtRefID.Text = dgvReference[0, row].Value.ToString();
            txtUserID.Text = dgvReference[1, row].Value.ToString();
            txtReferenceType.Text = dgvReference[2, row].Value.ToString();
            txtAuthor.Text = dgvReference[3, row].Value.ToString();
            txtTittle.Text = dgvReference[4, row].Value.ToString();
            txtPublishedYear.Text = dgvReference[5, row].Value.ToString();
            txtPublishedData.Text = dgvReference[6, row].Value.ToString();
            txtPublishedCompany.Text = dgvReference[7, row].Value.ToString();
            txtCity.Text = dgvReference[8, row].Value.ToString();
            txtRegion.Text = dgvReference[9, row].Value.ToString();
            txtEdition.Text = dgvReference[10, row].Value.ToString();
            txtPublisher.Text = dgvReference[11, row].Value.ToString();
            txtDataAccessed.Text = dgvReference[12, row].Value.ToString();
            txtIssue.Text = dgvReference[13, row].Value.ToString();
            txtVolume.Text = dgvReference[14, row].Value.ToString();
            txtNotes.Text = dgvReference[15, row].Value.ToString();
            txtPageNumbers.Text = dgvReference[16, row].Value.ToString();
        }

      

        private void addtagbtm_Click(object sender, EventArgs e)
        {
            string tagname = cbotag.SelectedItem.ToString();
            int row = dgvReference.CurrentRow.Index;
            string referenceid = dgvReference[1, row].Value.ToString();
            tr = new RefrencesDDOOCPDataSetTableAdapters.TagRefrenceTableAdapter();
            tr.Insert(tagname, referenceid);
            MessageBox.Show("added to tag successfully");
        }

       
    }
}
