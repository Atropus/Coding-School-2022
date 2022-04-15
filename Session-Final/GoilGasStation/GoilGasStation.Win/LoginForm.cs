using GoilGasStation.Blazor.Shared.ViewModels;
using GoilGasStation.Model;
using GoilGasStation.Win.Managers;
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
        EmployeeManager _employeeManager = new();
        private EmployeeViewModel _employeeViewModel;
        public LoginForm()
        {
            InitializeComponent();
            this.CenterToParent();
            _employeeViewModel = new EmployeeViewModel();
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
        private async void Authenticate()
        {
            if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                var employeelist = await _employeeManager.GetEmployees();
                if (employeelist is not null) 
                { 
                  var existinguser = employeelist.Find(x => x.Username.Equals(txtUsername.Text));
                  var existingpass = employeelist.Find(x => x.Password.Equals(txtPassword.Text));
                    if (existinguser is not null && existingpass is not null)
                    {
                        GoilGasStationForm form = new GoilGasStationForm();
                        form.ShowDialog();
                    }
                }

            }
            MessageBox.Show("Wrong Username or Password, please try again.", "Try Again");
            //Employee user = new Employee();
            //user.Username = txtUsername.Text;
            //user.Password = txtPassword.Text;

            if (txtUsername.Text!=string.Empty && txtPassword.Text!=string.Empty)
            {
                
                
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
