using GoilGasStation.Win.Managers;

namespace GoilGasStation.Win
{
    public partial class GoilGasStationForm : Form
    {
        private CustomerManager _customerManager;
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
            TransactionForm form = new TransactionForm();
            form.ShowDialog();
        }

        private void GoilGasStationForm_Load(object sender, EventArgs e)
        {

        }
    }
}