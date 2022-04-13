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
    public partial class TransactionForm : Form
    {
        private TransactionManager _transactionManager = new();
        private TransactionViewModel _transactionViewModel;
        private TransactionLineManager _transactionLineManager = new();
        private TransactionLineViewModel _transactionLineViewModel;
        private CustomerManager _customerManager = new();
        private CustomerViewModel _customerViewModel;
        private ItemManager _itemManager = new();
        private ItemViewModel _itemViewModel;
        private EmployeeViewModel _employeeViewModel;
        private EmployeeManager _employeeManager = new();


        public TransactionForm()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            txtDate.Text = Convert.ToString(DateTime.UtcNow);
            bsTransactionSource.DataSource = _transactionViewModel;
            spinQuantity.Minimum = 0;
            SetDataBinding();
        }

        private void SetDataBinding()
        {
            /TODO
            cmbItemType.DataSource = Enum.GetValues(typeof(ItemType));
            cmbItemType.DataBindings.Add(new Binding("Text", bsTransactionSource, "ItemType", true));
            cmbItemType.SelectedIndex = -1;
            cmbItemType.Text = "Select a Category";
            //txtCode.DataBindings.Add(new Binding("Text", bsTransactionSource, "Code", true))
            //txtCardNumber.DataBindings.Add(new Binding("Text", bsTransactionSource, "CardNumber", true));

            ////txtDate.DataBindings.Add(new Binding("Date", bsTransactionSource, ))
        }
        private async void RefreshTransData()
        {
            
        }

        private async Task RefreshTransLineData()
        {
            grdTransactionLines.DataSource = null;
            grdTransactionLines.DataSource = await _transactionLineManager.GetTransactionLines();
            grdTransactionLines.Update();
            grdTransactionLines.Refresh();
            grdTransactionLines.Columns["ID"].Visible = false;
            grdTransactionLines.Columns["TransactionID"].Visible = false;
            grdTransactionLines.Columns["ItemID"].Visible = false;


        }

        public bool CheckCardNumber(string cardNumber)
        {
            if (cardNumber is not null && cardNumber.Length == 6) return true;

            else return false;
        }

        private async void txtCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCustomerName.Text = String.Empty;
            txtCustomerSurname.Text = String.Empty;
            var customerlist = await _customerManager.GetCustomers();
            if (CheckCardNumber(txtCardNumber.Text) == true && customerlist is not null);
            {
                
                var customer = customerlist.SingleOrDefault(c => c.CardNumber == txtCardNumber.Text);
                if (customer is not null)
                {
                    txtCustomerName.Text = customer.Name;
                    txtCustomerSurname.Text = customer.Surname;
                    txtCustomerID.Text = Convert.ToString(customer.ID);
                }
                MessageBox.Show(this, "Wrong Card Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void cmbItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCode.Text = String.Empty;
            cmbDescription.Text = String.Empty;
            spinQuantity.Value = 1;
            txtPrice.Text = String.Empty;
            var itemlist = await _itemManager.GetItems();
            if (itemlist is not null)
            {
                //txtCode.Text = itemlist.Code;
            }
                var customerlist = await _customerManager.GetCustomers();
                var customer = customerlist.SingleOrDefault(c => c.CardNumber == txtCardNumber.Text);
                if (customer is not null)
                {
                    txtCustomerName.Text = customer.Name;
                    txtCustomerSurname.Text = customer.Surname;
                    txtCustomerID.Text = Convert.ToString(customer.ID);
                }
                MessageBox.Show(this, "Wrong Card Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}
