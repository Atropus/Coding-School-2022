using GoilGasStation.Blazor.Shared.ViewModels;
using GoilGasStation.Win.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoilGasStation.Win
{
    public partial class NewCustomerForm : Form
    {
        private CustomerManager _customerManager;
        private CustomerViewModel _customerViewModel;
        public NewCustomerForm()
        {
            InitializeComponent();
            _customerManager = new CustomerManager();
            this.CenterToParent();

        }
        public NewCustomerForm(CustomerViewModel customer) : this()
        {
            _customerViewModel = customer;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text is not null && txtSurname.Text is not null && txtCardNumber.Text is not null && txtCardNumber.Text[0] == 'A'
            && txtCardNumber.Text.Count() == 6)
            {
                if (_customerViewModel.ID == Guid.Empty)
                {

                    await _customerManager.CreateCustomer(_customerViewModel);
                    
                }
                else
                {
                    await _customerManager.PutCustomer(_customerViewModel);
                }
                this.Close();
                
            }
            else MessageBox.Show("Please fill all the fields properly");

        }
        private void SetDataBindings()
        {
            txtName.DataBindings.Add(new Binding("Text", bsCustomerSource, "Name", true));
            txtSurname.DataBindings.Add(new Binding("Text", bsCustomerSource, "Surname", true));
            txtCardNumber.DataBindings.Add(new Binding("Text", bsCustomerSource, "CardNumber", true));
        }

        private async void NewCustomerForm_Load(object sender, EventArgs e)
        {
            txtCardNumber.ReadOnly = true;
            if (_customerViewModel == null)
            {
                _customerViewModel = new CustomerViewModel();
                var customerlist = await _customerManager.GetCustomers();
                if (customerlist.Count() !=0)
                {
                    var maxCN = customerlist.Max(c => c.CardNumber);
                    var newString = Regex.Replace(maxCN, "\\d+", m => (int.Parse(m.Value) + 1).ToString(new string('0', m.Value.Length)));
                    _customerViewModel.CardNumber = newString;
                    txtCardNumber.Text = newString;
                        
                }
                else
                {
                    _customerViewModel.CardNumber = "A10001";
                    txtCardNumber.Text = "A10001";
                }
            }
            bsCustomerSource.DataSource = _customerViewModel;
            SetDataBindings();
 
        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
