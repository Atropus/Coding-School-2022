using PetShopLibrary;
using System;
using System.ComponentModel.DataAnnotations;

public class Customer : Person
{
    [Required]
    public string PhoneNumber { get; set; }
    public string Tin { get; set; }

    public List<Transaction> Transactions { get; set; }

    public Customer()
    {

    }

    public Customer(string name, string surname, string phoneNumber, string tin):base(name,surname)
    {
       PhoneNumber = phoneNumber;
       Tin = tin;
      
    }
}
