using GoilGasStation.Blazor.Client.Shared;
using GoilGasStation.Blazor.Shared.ViewModels;
using GoilGasStation.EF.Repositories;
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
        private readonly IEntityRepo<Item> _itemRepo;
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
            if (txtCode.Text is not null && txtDescription.Text is not null && txtPrice.Text is not null && txtCost.Text is not null && cmbItemType.SelectedIndex >= 0)
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
            cmbItemType.DataBindings.Add(new Binding("Text", bsItemSource, "ItemType", true));
            cmbItemType.SelectedIndex = -1;
            cmbItemType.Text = "Please choose a type...";
            txtPrice.DataBindings.Add(new Binding("Text", bsItemSource, "Price", true));
            txtCost.DataBindings.Add(new Binding("Text", bsItemSource, "Cost", true));

        }

        private async void NewItemForm_Load(object sender, EventArgs e)
        {

            txtCode.ReadOnly = true;
            if (_itemViewModel == null)
            {
                _itemViewModel = new ItemViewModel();
                var itemlist = await _itemManager.GetItems();
                if (itemlist.Count() != 0)
                {
                    var maxCode = itemlist.Max(c => c.Code);
                    //var existingItem= await _itemRepo.GetByIdAsync(itemlist[0].ID);
                    _itemViewModel.Code = maxCode + 1;
                    txtCode.Text = Convert.ToString(maxCode + 1);
                }
                else
                {
                    _itemViewModel.Code = 10001;
                    txtCode.Text = "10001";
                }

            }
            bsItemSource.DataSource = _itemViewModel;
            SetDataBindings();

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


