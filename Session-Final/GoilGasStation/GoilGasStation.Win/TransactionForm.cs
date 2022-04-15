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

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            if (_itemViewModel == null && _transactionViewModel == null)
            {
                _itemViewModel = new ItemViewModel();
                _transactionViewModel = new TransactionViewModel();
                _transactionViewModel.TransactionLines = new();
            }
            txtDate.Text = Convert.ToString(DateTime.UtcNow);
            cmbItemType.Enabled = false;
            txtCode.Enabled = false;
            cmbDescription.Enabled = false;
            spinQuantity.Enabled = false;
            bsItemSource.DataSource = _itemViewModel;
            bsTransactionSource.DataSource = _transactionViewModel;
            spinQuantity.Minimum = 0;
            //cmbItemType.SelectedIndex = -1;
            //cmbItemType.Text = "Choose a Category";
            SetDataBinding();
        }


        private async void SetDataBinding()
        {
            await _itemManager.GetItems();
            cmbItemType.DataSource = Enum.GetValues(typeof(ItemType));
            cmbItemType.DataBindings.Add(new Binding("Text", bsItemSource, "ItemType", true));
            txtCode.DataBindings.Add(new Binding("Text", bsItemSource, "Code", true));
            cmbDescription.DataBindings.Add(new Binding("Text", bsItemSource, "Description", true));
            txtPrice.DataBindings.Add(new Binding("Text", bsItemSource, "Price", true));
            cmbPaymentMethod.DataSource = Enum.GetValues(typeof(PaymentMethod));
            cmbPaymentMethod.DataBindings.Add(new Binding("Text", bsTransactionSource, "PaymentMethod", true));
        }
        private void RefreshTransData()
        {
            txtNetValue.Text = "0";
            txtDiscountValue.Text = "0";
            txtTotalValue.Text = "0";
            for (int i = 0; i < grdTransactionLines.Rows.Count; i++)
            {
                txtNetValue.Text = Convert.ToString(double.Parse(txtNetValue.Text) + double.Parse(grdTransactionLines.Rows[i].Cells[5].Value.ToString()));
                txtDiscountValue.Text = Convert.ToString(double.Parse(txtDiscountValue.Text) + double.Parse(grdTransactionLines.Rows[i].Cells[7].Value.ToString()));
                txtTotalValue.Text = Convert.ToString(double.Parse(txtTotalValue.Text) + double.Parse(grdTransactionLines.Rows[i].Cells[8].Value.ToString()));
            }

        }

        private async Task RefreshTransLineData()
        {
            grdTransactionLines.DataSource = null;
            grdTransactionLines.DataSource = _transactionViewModel.TransactionLines;
            grdTransactionLines.Update();
            grdTransactionLines.Refresh();
            grdTransactionLines.Columns["ID"].Visible = false;
            grdTransactionLines.Columns["TransactionID"].Visible = false;
            grdTransactionLines.Columns["ItemID"].Visible = false;
            //grdTransactionLines.Columns["DiscountPercent"].Visible = false;
            //grdTransactionLines.Columns["DiscountValue"].Visible = false;
            //grdTransactionLines.Columns["TotalValue"].Visible = false;
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
            if (CheckCardNumber(txtCardNumber.Text) == true && customerlist is not null)
            {

                var customer = customerlist.SingleOrDefault(c => c.CardNumber == txtCardNumber.Text);
                if (customer is not null)
                {
                    txtCustomerName.Text = customer.Name;
                    txtCustomerSurname.Text = customer.Surname;
                    txtCustomerID.Text = Convert.ToString(customer.ID);
                    cmbItemType.Enabled = true;
                    txtCode.Enabled = true;
                    cmbDescription.Enabled = true;
                    spinQuantity.Enabled = true;
                }
                else if (customer is null)
                {
                    MessageBox.Show(this, "Wrong Card Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            //MessageBox.Show(this, "Wrong Card Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void cmbItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCode.Text = String.Empty;
            cmbDescription.DataSource = null;
            spinQuantity.Value = 1;
            txtPrice.Text = String.Empty;

            var itemlist = await _itemManager.GetItems();
            var item = itemlist.Where(i => (int)i.ItemType == cmbItemType.SelectedIndex).ToList();
            cmbDescription.DataSource = item;
            cmbDescription.DisplayMember = "Description";
            cmbDescription.ValueMember = "ID";
            if (cmbItemType.SelectedIndex >= 0 && item is not null && itemlist is not null)
            {
                _itemViewModel.ID = item.FirstOrDefault(i => i.ID != Guid.Empty).ID;
                _itemViewModel.Code = item.FirstOrDefault(i => i.ID != Guid.Empty).Code;
                _itemViewModel.Description = item.FindAll(i => i.Description != null).ToString();
                _itemViewModel.Price = item.FirstOrDefault(i => i.ID != Guid.Empty).Price;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal netValueTotal = 0.00M;
            var newTransLine = new TransactionLineViewModel();
            newTransLine.ItemPrice = _itemViewModel.Price;
            newTransLine.Quantity = spinQuantity.Value;
            newTransLine.ItemID = _itemViewModel.ID;
            newTransLine.NetValue = newTransLine.ItemPrice * newTransLine.Quantity;
            _transactionViewModel.TransactionLines.Add(newTransLine);
            RefreshTransLineData();
            for (int i = 0; i < grdTransactionLines.Rows.Count; i++)
            {
                netValueTotal += Convert.ToDecimal(grdTransactionLines.Rows[i].Cells[5].Value);

            }
            if (netValueTotal >= 20)
            {
                txtDiscountPercent.Text = "10%";
                for (int i = 0; i < grdTransactionLines.Rows.Count; i++)
                {
                    var ii = _transactionViewModel.TransactionLines.FindIndex(c => c.DiscountPercent == 0);
                    if (ii >= 0)
                    {
                        _transactionViewModel.TransactionLines[ii].DiscountPercent = 0.10M;
                        _transactionViewModel.TransactionLines[ii].DiscountValue = newTransLine.NetValue * _transactionViewModel.TransactionLines[ii].DiscountPercent;
                        _transactionViewModel.TransactionLines[ii].TotalValue = newTransLine.NetValue - _transactionViewModel.TransactionLines[ii].DiscountValue;
                    }
                }
                newTransLine.DiscountPercent = 0.10M;
                newTransLine.DiscountValue = newTransLine.NetValue * newTransLine.DiscountPercent;
                newTransLine.TotalValue = newTransLine.NetValue - newTransLine.DiscountValue;
            }
            else
            {
                newTransLine.DiscountPercent = 0.00M;
                newTransLine.DiscountValue = newTransLine.NetValue * newTransLine.DiscountPercent;
                newTransLine.TotalValue = newTransLine.NetValue - newTransLine.DiscountValue;
            }
            RefreshTransLineData();
            RefreshTransData();

        }
        private async void cmbItemType_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (grdTransactionLines.SelectedRows.Count != 1)
            //    return;

            //_transactionViewModel.TransactionLines temp = (_transactionViewModel.TransactionLines)grdTransactionLines.SelectedRows
            //var item = (TransactionViewModel)grdTransactionLines.SelectedRows[index: 0].DataBoundItem;
            //_transactionViewModel.TransactionLines[item] 


            //RefreshTransLineData();
            //RefreshTransData(); ;
        }

        private async void cmbDescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCode.Text = String.Empty;
            //cmbItemType.SelectedIndex = 0;
            spinQuantity.Value = 1;
            txtPrice.Text = String.Empty;

            var itemlist = await _itemManager.GetItems();
            var item = itemlist.Where(i => i.Description == cmbDescription.Text).ToList();
            if (cmbDescription.SelectedIndex >= 0 && item is not null && itemlist is not null)
            {
                _itemViewModel.ID = item.FirstOrDefault(i => i.ID != Guid.Empty).ID;
                _itemViewModel.Code = item.FirstOrDefault(i => i.ID != Guid.Empty).Code;
                _itemViewModel.Price = item.FirstOrDefault(i => i.ID != Guid.Empty).Price;
            }

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            //var el = await _employeeManager.GetEmployees();
            //var empl = el.FirstOrDefault(i => i.ID != Guid.Empty).ID;
            //_transactionViewModel.EmployeeID = empl;
            if (_transactionViewModel is not null && _transactionLineViewModel is not null)
            {
                if (_transactionViewModel.ID == Guid.Empty)
                {

                    _transactionManager.CreateTransaction(_transactionViewModel);

                }
                else
                {
                    _transactionManager.PutTransaction(_transactionViewModel);
                }
            }
        }
    }
}
