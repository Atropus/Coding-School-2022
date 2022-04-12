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
    public partial class NewItemForm : Form
    {
        private ItemManager _itemManager;
        private ItemViewModel _itemViewModel;
        public NewItemForm()
        {
            InitializeComponent();
            _itemManager = new ItemManager();
            this.CenterToParent();

        }
        public NewItemForm(ItemViewModel item) : this()
        {
            _itemViewModel = item;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCode.Text is not null && txtDescription.Text is not null && txtPrice.Text is not null && txtCost.Text is not null && cmbItemType.SelectedIndex>0)
            {
                if (_itemViewModel.ID == Guid.Empty)
                {

                    _itemManager.CreateItem(_itemViewModel);

                }
                else
                {
                    _itemManager.PutItem(_itemViewModel);
                }
                this.Close();

            }
            else MessageBox.Show("Please fill all the fields properly");

        }
        private void SetDataBindings()
        {
            txtCode.DataBindings.Add(new Binding("Text", bsItemSource, "Code", true));
            txtDescription.DataBindings.Add(new Binding("Text", bsItemSource, "Description", true));
            cmbItemType.DataSource = Enum.GetValues(typeof(ItemType));
            cmbItemType.SelectedIndex = 0;
            cmbItemType.Text = "Please choose a type...";
            txtPrice.DataBindings.Add(new Binding("Text", bsItemSource, "Price", true));
            txtCost.DataBindings.Add(new Binding("Text", bsItemSource, "Cost", true));

        }

        private void NewItemForm_Load(object sender, EventArgs e)
        {
            
            if (_itemViewModel == null)
            {
                _itemViewModel = new ItemViewModel();
                
            }
            bsItemSource.DataSource = _itemViewModel;
            SetDataBindings();

            //txtCardNumber.Font = new Font("Arial", 10, FontStyle.Italic, GraphicsUnit.Point);
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


