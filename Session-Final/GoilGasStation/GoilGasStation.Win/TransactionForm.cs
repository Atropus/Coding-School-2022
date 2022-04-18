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
        private TransactionLineViewModel _transactionLineViewModel = new();
        private CustomerManager _customerManager = new();
        private CustomerViewModel _customerViewModel;
        private ItemManager _itemManager = new();
        private ItemViewModel _itemViewModel;
        private EmployeeViewModel _employeeViewModel;
        private EmployeeManager _employeeManager = new();
        private Guid _employeeID;

        public TransactionForm(Guid employeeID)
        {
            InitializeComponent();
            this.CenterToParent();
            _employeeID = employeeID;
        }
        private void TransactionForm_Load(object sender, EventArgs e)
        {
            if (_itemViewModel == null && _transactionViewModel == null)
            {
                _itemViewModel = new ItemViewModel();
                _transactionViewModel = new TransactionViewModel();
                _transactionViewModel.TransactionLines = new();
            }
            cmbItemType.Enabled = false;
            txtCode.Enabled = false;
            cmbDescription.Enabled = false;
            spinQuantity.Enabled = false;
            bsItemSource.DataSource = _itemViewModel;
            bsTransactionSource.DataSource = _transactionViewModel;
            spinQuantity.Minimum = 0;

            SetDataBinding();
        }
        private async void SetDataBinding()
        {
            await _itemManager.GetItems();
            cmbItemType.DataSource = Enum.GetValues(typeof(ItemType));
            cmbItemType.DataBindings.Add(new Binding("SelectedValue", bsItemSource, "ItemType", true));
            txtCode.DataBindings.Add(new Binding("Text", bsItemSource, "Code", true));
            cmbDescription.DataBindings.Add(new Binding("Text", bsItemSource, "Description", true));
            txtPrice.DataBindings.Add(new Binding("Text", bsItemSource, "Price", true));
            cmbPaymentMethod.DataSource = Enum.GetValues(typeof(PaymentMethod));
            cmbPaymentMethod.DataBindings.Add(new Binding("SelectedValue", bsTransactionSource, "PaymentMethod", true));
            txtCustomerID.DataBindings.Add(new Binding("Text", bsTransactionSource, "CustomerID", true));
            txtTotalValue.DataBindings.Add(new Binding("Text", bsTransactionSource, "TotalValue", true));
            txtDate.DataBindings.Add(new Binding("Text", bsTransactionSource, "Date", true));
            txtDate.Text = Convert.ToString(DateTime.UtcNow);
            txtEmployeeID.DataBindings.Add(new Binding("Text", bsTransactionSource, "EmployeeID", true));
            _transactionViewModel.EmployeeID = _employeeID;
            var employeelist = await _employeeManager.GetEmployees();
            var currentemployee = employeelist.Find(e => e.ID == _employeeID);
            if (currentemployee != null)
            {
                txtUserName.Text = currentemployee.Name;
                txtUserSurname.Text = currentemployee.Surname;
            }
            cmbItemType.SelectedIndex = 0;
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
                    _transactionViewModel.CustomerID = customer.ID;
                    cmbItemType.Enabled = true;
                    txtCode.Enabled = true;
                    cmbDescription.Enabled = true;
                    spinQuantity.Enabled = true;
                }
                else if (customer is null)
                {
                    var result = MessageBox.Show(this, "Wrong Card Number, Do you want to Create a Customer?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (result == DialogResult.Yes)
                    {
                        CustomerForm form = new CustomerForm();
                        form.ShowDialog();
                    }
                    else if (result == DialogResult.No)
                    {
                        return;
                    }
                }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
                if (netValueTotal >= 50)
                {
                    cmbPaymentMethod.Enabled = false;
                    cmbPaymentMethod.SelectedIndex = 1;
                }
                txtDiscountPercent.Text = "10%";
                for (int i = 0; i < grdTransactionLines.Rows.Count; i++)
                {
                    var ii = _transactionViewModel.TransactionLines.FindIndex(c => c.DiscountPercent == 0);
                    if (ii >= 0)
                    {
                        _transactionViewModel.TransactionLines[ii].DiscountPercent = 0.10M;
                        _transactionViewModel.TransactionLines[ii].DiscountValue = _transactionViewModel.TransactionLines[ii].NetValue * _transactionViewModel.TransactionLines[ii].DiscountPercent;
                        _transactionViewModel.TransactionLines[ii].TotalValue = _transactionViewModel.TransactionLines[ii].NetValue - _transactionViewModel.TransactionLines[ii].DiscountValue;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            decimal netValueTotal = 0.00M;

            var newTransLine = new TransactionLineViewModel();
            if (grdTransactionLines.SelectedRows.Count != 1)
                return;
            var selectedindex = grdTransactionLines.CurrentRow.Index;
            var deletetransline = (TransactionLineViewModel)grdTransactionLines.Rows[index: selectedindex].DataBoundItem;
            _transactionViewModel.TransactionLines.Remove(deletetransline);
            RefreshTransLineData();
            for (int i = 0; i < grdTransactionLines.Rows.Count; i++)
            {
                netValueTotal += Convert.ToDecimal(grdTransactionLines.Rows[i].Cells[5].Value);

            }
            if (netValueTotal >= 20)
            {
                txtDiscountPercent.Text = "10%";
                if (netValueTotal >= 50)
                {
                    cmbPaymentMethod.Enabled = false;
                    cmbPaymentMethod.SelectedIndex = 1;
                }
                else if (netValueTotal < 50)
                {
                    cmbPaymentMethod.Enabled = true;
                    cmbPaymentMethod.SelectedIndex = 0;
                }

                for (int i = 0; i < grdTransactionLines.Rows.Count; i++)
                {
                    var ii = _transactionViewModel.TransactionLines.FindIndex(c => c.DiscountPercent == 0);
                    if (ii >= 0)
                    {
                        _transactionViewModel.TransactionLines[ii].DiscountPercent = 0.10M;
                        _transactionViewModel.TransactionLines[ii].DiscountValue = _transactionViewModel.TransactionLines[ii].NetValue * _transactionViewModel.TransactionLines[ii].DiscountPercent;
                        _transactionViewModel.TransactionLines[ii].TotalValue = _transactionViewModel.TransactionLines[ii].NetValue - _transactionViewModel.TransactionLines[ii].DiscountValue;
                    }
                }
                newTransLine.DiscountPercent = 0.10M;
                newTransLine.DiscountValue = newTransLine.NetValue * newTransLine.DiscountPercent;
                newTransLine.TotalValue = newTransLine.NetValue - newTransLine.DiscountValue;
            }
            else
            {
                for (int i = 0; i < grdTransactionLines.Rows.Count; i++)
                {
                    var ii = _transactionViewModel.TransactionLines.FindIndex(c => c.DiscountPercent > 0);
                    if (ii >= 0)
                    {
                        _transactionViewModel.TransactionLines[ii].DiscountPercent = 0.00M;
                        _transactionViewModel.TransactionLines[ii].DiscountValue = _transactionViewModel.TransactionLines[ii].NetValue * _transactionViewModel.TransactionLines[ii].DiscountPercent;
                        _transactionViewModel.TransactionLines[ii].TotalValue = _transactionViewModel.TransactionLines[ii].NetValue - _transactionViewModel.TransactionLines[ii].DiscountValue;
                    }
                }
                txtDiscountPercent.Text = "0%";
                newTransLine.DiscountPercent = 0.00M;
                newTransLine.DiscountValue = newTransLine.NetValue * newTransLine.DiscountPercent;
                newTransLine.TotalValue = newTransLine.NetValue - newTransLine.DiscountValue;
            }
            RefreshTransLineData();
            RefreshTransData();
        }

        private async void cmbDescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtCode.Text = String.Empty;
            ////cmbItemType.SelectedIndex = 0;
            spinQuantity.Value = 1;
            //txtPrice.Text = String.Empty;

            var itemlist = await _itemManager.GetItems();
            var item = itemlist.Where(i => i.Description == cmbDescription.Text).ToList();
            if (cmbDescription.SelectedIndex >= 0 && item is not null && itemlist is not null && item.Count() > 0)
            {
                _itemViewModel.ID = item.FirstOrDefault(i => i.ID != Guid.Empty).ID;
                _itemViewModel.Code = item.FirstOrDefault(i => i.ID != Guid.Empty).Code;
                _itemViewModel.Price = item.FirstOrDefault(i => i.ID != Guid.Empty).Price;
            }

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTotalValue.Text != "0" || txtNetValue.Text != "")
            {
                _transactionViewModel.Date = Convert.ToDateTime(txtDate.Text);
                _transactionViewModel.TotalValue = Convert.ToDecimal(txtTotalValue.Text);
                var enu = cmbPaymentMethod.SelectedIndex;
                _transactionViewModel.PaymentMethod = (PaymentMethod)enu;
                if (_transactionViewModel is not null)
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
                this.Close();

            }
            MessageBox.Show(this, "Please input a Line", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private async void cmbItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtCode.Text = String.Empty;
            cmbDescription.DataSource = null;
            //spinQuantity.Value = 1;
            //txtPrice.Text = String.Empty;

            var itemlist = await _itemManager.GetItems();
            var item = itemlist.Where(i => (int)i.ItemType == cmbItemType.SelectedIndex).ToList();
            cmbDescription.DataSource = item;
            cmbDescription.DisplayMember = "Description";
            cmbDescription.ValueMember = "ID";
            //if (cmbItemType.SelectedIndex >= 0 && item is not null && itemlist is not null)
            //{
            //    _itemViewModel.ID = item.FirstOrDefault(i => i.ID != Guid.Empty).ID;
            //    _itemViewModel.Code = item.FirstOrDefault(i => i.ID != Guid.Empty).Code;
            //    _itemViewModel.Description = item.FindAll(i => i.Description != null).ToString();
            //    _itemViewModel.Price = item.FirstOrDefault(i => i.ID != Guid.Empty).Price;
            //}
        }
    }
}
