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

                    _customerManager.CreateCustomer(_customerViewModel);
                    
                }
                else
                {
                    _customerManager.PutCustomer(_customerViewModel);
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

        private void NewCustomerForm_Load(object sender, EventArgs e)
        {

            if (_customerViewModel == null)
            {
                _customerViewModel = new CustomerViewModel();
                _customerViewModel.CardNumber = "e.x. A10001, A10002";
            }
            bsCustomerSource.DataSource = _customerViewModel;
            SetDataBindings();
            
            //txtCardNumber.Font = new Font("Arial", 10, FontStyle.Italic, GraphicsUnit.Point);
        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
