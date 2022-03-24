using PetShopLibrary;
using System;
using System.ComponentModel.DataAnnotations;

public enum EmployeeType
{
	CEO,
	Manager,
	Employee,
}

public interface IEmployee
{
	EmployeeType EmpType { get; set; }

}
public class Employee : Person, IEmployee
{
	[Required]
	public decimal Salary { get; set; }
	public EmployeeType EmpType { get; set; }
	public List<Transaction> Transactions { get; set; }

	public Employee()
    {

    }
	public Employee(string name, string surname,decimal salary):base(name, surname)
	{
		Salary = salary;
	}
}
