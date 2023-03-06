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
    public partial class Login : Form
    {
        public static string LoginUserName,LoginPassword,LoginID;

        RefrencesDDOOCPDataSetTableAdapters.User_TableAdapter ut;
        
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ut = new RefrencesDDOOCPDataSetTableAdapters.User_TableAdapter();

            string UserName, Password;
            UserName = txtUsername.Text;
            Password = txtPassword.Text;
            
            if (txtPassword.Text=="")
            {
                MessageBox.Show("Username or password incorrect!");
            }
            else if (txtUsername.Text == "")
            {
                MessageBox.Show("Username or password incorrect!");
            }
            else
            {
                int Login;
                Login = Int32.Parse(ut.Login(UserName, Password).ToString());
                if (Login == 0)
                {
                    txtPassword.Text = "";
                    txtUsername.Text = "";
                    MessageBox.Show("Username or password incorrect!");

                }
                else
                {
                    dgvUser.DataSource = ut.GetDataByUserID(UserName, Password).CopyToDataTable();
                    LoginID=dgvUser[5, 0].Value.ToString();
                    MessageBox.Show("Successfully login");
                    LoginUserName = UserName;
                    LoginPassword = Password;
                    Mainmenu m = new Mainmenu();
                    m.Show();
                    this.Hide();

                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            UserRegister ur = new UserRegister();
            ur.Show();
            this.Hide();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'refrencesDDOOCPDataSet.User_' table. You can move, or remove it, as needed.
            //this.user_TableAdapter.Fill(this.refrencesDDOOCPDataSet.User_);

        }
    }
}
