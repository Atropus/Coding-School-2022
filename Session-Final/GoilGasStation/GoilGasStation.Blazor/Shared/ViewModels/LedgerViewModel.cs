using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoilGasStation.Blazor.Shared.ViewModels
{
    public class LedgerViewModel
    {
        public short Year { get; set; }
        public sbyte Month { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public decimal Total { get; set; }
    }
}
