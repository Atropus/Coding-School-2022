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
    public partial class TransactionForm : Form
    {
        private TransactionManager _transactionManager;
        private TransactionViewModel _transactionViewModel;
        private TransactionLineManager _transactionLineManager;
        private TransactionLineViewModel _transactionLineViewModel;

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
            
            RefreshData();
        }

        private async Task RefreshData()
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

        private void txtCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtCustomerName.Text = String.Empty;
            txtCustomerSurname.Text = String.Empty;

            if (CheckCardNumber(txtCardNumber.Text) == true)
            {
                
            }
            else
            {
                MessageBox.Show(this, "Wrong Card Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
