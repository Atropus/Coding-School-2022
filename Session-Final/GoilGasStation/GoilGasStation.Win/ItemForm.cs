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
    public partial class ItemForm : Form
    {
        private ItemManager _itemManager;
        private ItemViewModel _itemViewModel;
        public ItemForm()
        {
            _itemManager = new ItemManager();
            InitializeComponent();
            this.CenterToScreen();
        }

        private async void btnNewItem_Click(object sender, EventArgs e)
        {
            NewItemForm form = new NewItemForm();
            form.ShowDialog();
            await RefreshData();
        }

        private async void ItemForm_Load(object sender, EventArgs e)
        {
            grdItemList.ReadOnly = true;
            RefreshData();

        }
        private async Task RefreshData()
        {
            grdItemList.DataSource = null;
            grdItemList.DataSource = await _itemManager.GetItems();
            grdItemList.Update();
            grdItemList.Refresh();
            grdItemList.Columns["ID"].Visible = false;

        }

        private async void btnEditItem_Click(object sender, EventArgs e)
        {
            if (grdItemList.SelectedRows.Count != 1)
                return;

            var item = (ItemViewModel)grdItemList.SelectedRows[index: 0].DataBoundItem;
            var itemEdit = new NewItemForm(item);
            itemEdit.ShowDialog();

            await RefreshData();
        }

        private async void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (grdItemList.SelectedRows.Count != 1)
                return;

            var item = (ItemViewModel)grdItemList.SelectedRows[index: 0].DataBoundItem;
            _itemManager.DeleteItem(item);

            await RefreshData();
        }
    }
}

