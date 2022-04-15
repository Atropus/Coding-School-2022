using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoilGasStation.Model;

namespace GoilGasStation.Blazor.Shared.ViewModels
{
    public class EmployeeViewModel
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? HireDateStart { get; set; } = DateTime.Now; 
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? HireDateEnd { get; set; }
        public decimal SalaryPerMonth { get; set; }
        //[EnumDataType(typeof(EmployeeType))]
        public EmployeeType EmployeeType { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
    }

    public class EmployeeEditViewModel
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime HireDateStart { get; set; } = DateTime.Now;
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? HireDateEnd { get; set; }
        public decimal SalaryPerMonth { get; set; }
        //[EnumDataType(typeof(EmployeeType))]
        public EmployeeType EmployeeType { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
