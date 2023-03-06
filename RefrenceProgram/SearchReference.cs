using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;


namespace RefrenceProgram
{
    public partial class SearchReference : Form
    {
        FileStream fs;
        string output;
        RefrencesDDOOCPDataSetTableAdapters.DataRefTableAdapter dr;
        public SearchReference()
        {

            InitializeComponent();
        }

        public void loaddata()
        {
            dr = new RefrencesDDOOCPDataSetTableAdapters.DataRefTableAdapter();
            dgvSearch.DataSource = dr.GetData().CopyToDataTable();
            

        }

        private void SerchRefence_Load(object sender, EventArgs e)
        {
            this.dataRefTableAdapter.Fill(this.refrencesDDOOCPDataSet.DataRef);

        }

        private void btm1_Click(object sender, EventArgs e)
        {
            string searchdata = txtSearch.Text;
            try
            {
                if (searchbytittle.Checked)
                {
                    dr = new RefrencesDDOOCPDataSetTableAdapters.DataRefTableAdapter();
                    dgvSearch.DataSource = dr.GetTitle(searchdata);
                }
                else if (searchbyauthor.Checked)
                {
                    dr = new RefrencesDDOOCPDataSetTableAdapters.DataRefTableAdapter();
                    dgvSearch.DataSource = dr.GetAuthor(searchdata);
                }
                else
                {
                    loaddata();
                }
            }
            catch
            {
            }
        }
    



        private void btm2_Click(object sender, EventArgs e)
        {
            loaddata();
            dr = new RefrencesDDOOCPDataSetTableAdapters.DataRefTableAdapter();
            dgvSearch.DataSource = dr.GetData().CopyToDataTable();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Mainmenu r = new Mainmenu();
            r.Show();
            this.Hide();
        }

        private void formatbtm_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dgvSearch.CurrentRow.Index;
                string combo = formatcombobox.SelectedItem.ToString();

                string combostyle = formatcombobox.SelectedItem.ToString();
                string RefID = (string)dgvSearch[0, row].Value;
                string UserID = (string)dgvSearch[1, row].Value;
                string RefrenceType = (string)dgvSearch[2, row].Value;
                string Author = (string)dgvSearch[3, row].Value;
                string Tittle = (string)dgvSearch[4, row].Value;
                string PublishedYear = (string)dgvSearch[5, row].Value;
                string PublishedDate = (string)dgvSearch[6, row].Value;
                string PublishedCompany = (string)dgvSearch[7, row].Value;
                string City = (string)dgvSearch[8, row].Value;
                string Region = (string)dgvSearch[9, row].Value;
                string Edition = (string)dgvSearch[10, row].Value;
                string Publisher = (string)dgvSearch[11, row].Value;

                if (combo.Equals("APA"))
                {
                    output = Author + "/(" + Tittle + ")/" + City + "\n";
                }
                else if (combo.Equals("Harvard"))
                {
                    output = Author + PublishedYear +Tittle;
                }
                else if (combo.Equals("Chicago"))
                {
                    output = Author + PublishedYear + Tittle + City;
                }
                lstFormat.Text = output.ToString();
            }
            catch (Exception)
            {
            }

        }

      

        private void exportbtm_Click(object sender, EventArgs e)
        {
            output = lstFormat.Text;
            fs = new FileStream("References.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            try
            {
                sw.WriteLine(output);
                MessageBox.Show("Sucessfully Save Data");
                
            }
            catch (Exception ceo)
            {
                MessageBox.Show(ceo.Message);
            }
            finally
            {
                sw.Dispose();
            }
        }

    }
}


