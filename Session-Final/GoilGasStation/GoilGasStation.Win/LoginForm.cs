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
        private async void Authenticate()
        {
            if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                var emid = Guid.Empty;
                
                var employeelist = await _employeeManager.GetEmployees();
                var users = employeelist.Where(x => x.Password is not null && x.Username is not null).ToList();
                if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
                {
                    GoilGasStationForm adminform = new GoilGasStationForm();
                    adminform.ShowDialog();
                    this.Close();
                }
                else if (users is not null)
                {
                    
                    var existinguser = users.Find(y => y.Password.Equals(txtPassword.Text) && y.Username.Equals(txtUsername.Text));
                    if (existinguser != null)
                    {
                        emid = existinguser.ID;
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password, please try again.", "Try Again");
                        return;
                    }

                } 
                GoilGasStationForm form = new GoilGasStationForm(emid);
                form.ShowDialog();
                this.Close();
            }           
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Authenticate();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
