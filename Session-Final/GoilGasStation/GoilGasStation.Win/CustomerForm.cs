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
            Refresh();
        }

        private async void CustomerForm_Load(object sender, EventArgs e)
        {
            grdCustomerList.ReadOnly = true;
            await RefreshData();
            Refresh();
            
        }

        private void Refresh()
        {
            grdCustomerList.Update();
            grdCustomerList.Refresh();
            grdCustomerList.Columns["ID"].Visible = false;

        }
        private async Task RefreshData()
        {
            var test = await _customerManager.GetCustomers();
            grdCustomerList.DataSource = null;
            grdCustomerList.DataSource = test;
        }

        private async void btnEditCustomer_Click(object sender, EventArgs e)
        {
            if (grdCustomerList.SelectedRows.Count != 1)
                return;

            var customer = (CustomerViewModel)grdCustomerList.SelectedRows[index: 0].DataBoundItem;
            var customerEdit = new NewCustomerForm(customer);
            customerEdit.ShowDialog();

            await RefreshData();
            Refresh();
        }

        private async void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (grdCustomerList.SelectedRows.Count != 1)
                return;
            try
            {
                var customer = (CustomerViewModel)grdCustomerList.SelectedRows[index: 0].DataBoundItem;
                await _customerManager.DeleteCustomer(customer);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            await RefreshData();
            Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
