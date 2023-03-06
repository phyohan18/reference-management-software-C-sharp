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
    public partial class UserRegister : Form
    {
        RefrencesDDOOCPDataSetTableAdapters.User_TableAdapter UT;
        public UserRegister()
        {
            InitializeComponent();
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            string  FirstName = txtFirstName.Text;
            string LastName = txtLastName.Text;
            string Dateofbirth = txtDateofbirth.Text;
            string Address = txtAddress.Text;
            int ID = int.Parse(textBox6.Text);
            string Email = txtEmail.Text;
            string UserName = txtUserName.Text;
            string SecurityKeys = txtSecurityKeys.Text;
            string Gender;
            if(radioButton1.Checked)
            {
                Gender ="Male";
            }
            else
            {
                Gender ="female";
            }
            UT = new RefrencesDDOOCPDataSetTableAdapters.User_TableAdapter();
            UT.InsertQuery(FirstName, LastName, Dateofbirth, Gender, Address, Email,SecurityKeys, UserName,ID);
            MessageBox.Show("Create account successfully");
            Clear();

        }
        public void Clear() 
        {
              string FirstName = txtFirstName.Text="";
              string LastName = txtLastName.Text = ""; 
              string Dateofbirth = txtDateofbirth.Text = ""; 
              string Address = txtAddress.Text = "";
              string ID = textBox6.Text = ""; 
              string Email = txtEmail.Text = ""; 
              string UserName = txtUserName.Text="";
              string SecurityKeys = txtSecurityKeys.Text="";
              string Gender;
        }

        private void UserRegister_Load(object sender, EventArgs e)
        {
            
            UT = new RefrencesDDOOCPDataSetTableAdapters.User_TableAdapter();
            int count=Int32.Parse(UT.COUNTUSER().ToString());
            int ID = count + 1;            

           
            textBox6.Text = ID.ToString();
           
        }

      

        private void btn2_Click(object sender, EventArgs e)
        {
            Login l = new Login();
          l.Show();
            this.Hide();
        }

         
    }
}
