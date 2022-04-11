using GoilGasStation.Model.Entities;
using System.ComponentModel.DataAnnotations;

namespace GoilGasStation.Model

{
    public class Employee : Person
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime HireDateStart { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime HireDateEnd { get; set; }
        public decimal SalaryPerMonth { get; set; }
        //[EnumDataType(typeof(EmployeeType))]
        public EmployeeType EmployeeType { get; set; }

        //todo
        //public string Username { get; set; }
        //public string Password { get; set; }


    }
}