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
    public partial class CustomerForm : Form
    {
        private CustomerManager _customerManager;
        private CustomerViewModel _customerViewModel;
        public CustomerForm()
        {
            _customerManager = new CustomerManager();
            InitializeComponent();
            this.CenterToScreen();
        }

        private async void btnNewCustomer_Click(object sender, EventArgs e)
        {
            NewCustomerForm form = new NewCustomerForm();
            form.ShowDialog();
            await RefreshData();
        }

        private async void CustomerForm_Load(object sender, EventArgs e)
        {
            grdCustomerList.ReadOnly = true;
            await RefreshData();
            
        }
        private async Task RefreshData()
        {
            grdCustomerList.DataSource = null;
            grdCustomerList.DataSource = await _customerManager.GetCustomers();
            grdCustomerList.Update();
            grdCustomerList.Refresh();
            grdCustomerList.Columns["ID"].Visible = false;

        }

        private async void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (grdCustomerList.SelectedRows.Count != 1)
                return;

            var customer = (CustomerViewModel)grdCustomerList.SelectedRows[index: 0].DataBoundItem;
            var customerEdit = new NewCustomerForm(customer);
            customerEdit.ShowDialog();

            await RefreshData();
        }

        private async void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (grdCustomerList.SelectedRows.Count != 1)
                return;

            var customer = (CustomerViewModel)grdCustomerList.SelectedRows[index: 0].DataBoundItem;
            _customerManager.DeleteCustomer(customer);

            await RefreshData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
