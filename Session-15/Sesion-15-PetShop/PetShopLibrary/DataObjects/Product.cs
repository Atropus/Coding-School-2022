using PetShopLibrary.DataObjects;
using System.ComponentModel.DataAnnotations;

namespace PetShopLibrary
{

    //interface Product
    public interface IProduct
    {
        decimal Price { get; set; }
        decimal Cost { get; set; }
        Guid ID { get; set; }
    }

    

    public class Product : CurrentStatus, IProduct
    {
        [Required]
        public decimal Price { get; set; }
        public decimal Cost { get; set; }
        [Required]
        public Guid ID { get; set; }


        public Product()
        {
            ID = Guid.NewGuid();
        }
    }
}