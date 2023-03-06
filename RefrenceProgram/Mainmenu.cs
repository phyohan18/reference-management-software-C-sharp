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
    public partial class Mainmenu : Form
    {
        RefrencesDDOOCPDataSetTableAdapters.User_TableAdapter UT;
           
        public Mainmenu()
        {
            InitializeComponent();
        }
          
     

        private void refrenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            References r = new References();
            r.Show();
            this.Hide();
        }

        private void btn1Logout_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void searchRefenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchReference s = new SearchReference();
            s.Show();
            this.Hide();
        }

     

        private void tagToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tag t = new Tag();
            t.Show();
            this.Hide();
        }

       

        private void mainmenu_Load(object sender, EventArgs e)
        {
            UT = new RefrencesDDOOCPDataSetTableAdapters.User_TableAdapter();
            lbluserID.Text = Login.LoginID;
            lbluserlabel.Text = "Welcome" + " " + Login.LoginUserName;
        }
 
       


        private void tagSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Searchbytag sbt = new Searchbytag();
            sbt.Show();
            this.Hide();
        }

       
    }
}
