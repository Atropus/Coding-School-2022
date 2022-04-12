using GoilGasStation.Blazor.Shared.ViewModels;
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

        private async void btnSave_Click(object sender, EventArgs e)
        {
            
            _customerManager.CreateCustomer(_customerViewModel);
            this.Close();
        }
        private void SetDataBindings()
        {
            txtName.DataBindings.Add(new Binding("Text", bsCustomerSource, "Name", true));
            txtSurname.DataBindings.Add(new Binding("Text", bsCustomerSource, "Surname", true));
            txtCardNumber.DataBindings.Add(new Binding("Text", bsCustomerSource, "CardNumber", true));
        }

        private void NewCustomerForm_Load(object sender, EventArgs e)
        {
            if(_customerViewModel == null)
            {
                _customerViewModel = new CustomerViewModel();
            }
            bsCustomerSource.DataSource = _customerViewModel;
            SetDataBindings();
        }
    }
}
