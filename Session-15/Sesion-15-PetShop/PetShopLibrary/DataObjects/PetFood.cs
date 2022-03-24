using PetShopLibrary;
using System;
using System.ComponentModel.DataAnnotations;

public enum FoodType
{
    CatFood,
    DogFood,
    FishFood,
    ReptilianFood,
    BirdFood,
    RatFood,
    TurtleFood,
    SnakeFood
}

public interface IFood
{
    FoodType Type { get; set; }
}

public class PetFood : Product, IFood
{
    [Required]
    public FoodType Type { get; set; }

    public string Brand { get; set; }
    //public Transaction Transactions { get; set; }

    public PetFood()
    {
        Brand = "";
    }

}


