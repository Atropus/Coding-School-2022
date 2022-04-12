using GoilGasStation.Win.Managers;

namespace GoilGasStation.Win
{
    public partial class GoilGasStationForm : Form
    {
        private CustomerManager _customerManager;
        public GoilGasStationForm()
        {
            InitializeComponent();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm form = new CustomerForm();
            form.ShowDialog();
        }
    }
}