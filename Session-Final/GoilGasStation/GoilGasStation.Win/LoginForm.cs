using GoilGasStation.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoilGasStation.Win
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            PasswordCover();
            txtPassword.KeyPress += LoginForm_KeyPress;
        }
        private void PasswordCover()
        {
            txtPassword.Text = "";
            txtPassword.PasswordChar = '*';
            txtPassword.MaxLength = 10;
        }

        private void LoginForm_KeyPress(object? sender, KeyPressEventArgs e)
        {

            if (e.KeyChar != 13) return;
            Authenticate();


        }
        private void Authenticate()
        {
            //Employee user = new Employee();
            //user.Username = txtUsername.Text;
            //user.Password = txtPassword.Text;

            if (1 == Auth())
            {
                this.Close();
            }
            else if (2 == Auth())
            {
                this.Close();
            }
            else if (3 == Auth())
            {
                this.Close();
            }
            else if (0 == Auth())
            {
                MessageBox.Show("Wrong Username or Password, please try again.", "Try Again");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Authenticate();
        }

        public int Auth()
        {
            //1.Manager 2.Staff 3.Cashier
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                return 1;
            }
            else if(txtUsername.Text == "staff" && txtPassword.Text == "staff")
            {
                return 2;
            }
            else if (txtUsername.Text == "cashier" && txtPassword.Text == "cashier")
            {
                return 3;
            }
            return 0;  
        }
    }
}
