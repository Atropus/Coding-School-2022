using GoilGasStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoilGasStation.Blazor.Shared.ViewModels
{
    public class ItemViewModel
    {
        public Guid ID { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public ItemType ItemType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
    }

    public class ItemEditViewModel
    {
        public Guid ID { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public ItemType ItemType { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
    }
}
