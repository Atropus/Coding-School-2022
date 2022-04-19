using GoilGasStation.Model;
using GoilGasStation.Win.Managers;

namespace GoilGasStation.Win
{
    public partial class GoilGasStationForm : Form
    {
        private CustomerManager _customerManager;
        private EmployeeManager _employeeManager = new();
        private Guid _employeeID;
        
        public GoilGasStationForm(Guid employeeID)
        {
            InitializeComponent();
            this.CenterToScreen();
            _employeeID = employeeID;
        }
        public GoilGasStationForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm form = new CustomerForm();
            form.ShowDialog();
        }

        private void fuelInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemForm form = new ItemForm();
            form.ShowDialog();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionForm form = new TransactionForm(_employeeID);
            form.ShowDialog();
        }

        private async void GoilGasStationForm_Load(object sender, EventArgs e)
        {
            
            var employeelist = await _employeeManager.GetEmployees();
            var currentemployee = employeelist.Find(e => e.ID == _employeeID);
            if (currentemployee != null)
            {
                lblEmployeeName.Text = currentemployee.Name;
                lblEmployeeSurname.Text = currentemployee.Surname;

                lblEmployeeType.Text = currentemployee.EmployeeType.ToString();
                if (currentemployee.EmployeeType.Equals(EmployeeType.Staff))
                {
                    customerToolStripMenuItem.Enabled = false;
                    customerToolStripMenuItem.Visible = false;
                    transactionToolStripMenuItem.Enabled = false;
                    transactionToolStripMenuItem.Visible = false;
                }
                else if (currentemployee.EmployeeType.Equals(EmployeeType.Cashier))
                {
                    fuelInventoryToolStripMenuItem.Enabled = false;
                    fuelInventoryToolStripMenuItem.Visible = false;
                }

            }
   
        }
    }
}