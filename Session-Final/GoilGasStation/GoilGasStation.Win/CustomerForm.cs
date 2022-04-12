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
        public CustomerForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            NewCustomerForm form = new NewCustomerForm();
            form.ShowDialog();
        }
    }
}
