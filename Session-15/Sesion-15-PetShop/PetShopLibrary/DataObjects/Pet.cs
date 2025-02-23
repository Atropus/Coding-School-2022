﻿using PetShopLibrary;
using System;
using System.ComponentModel.DataAnnotations;

public enum AnimalType
{
    Bird,
    Cat,
    Dog,
    Snake,
    Fish,
    Turtle,
    Rat
}


public enum PetStatus
{
    OK,
    Unhealthy,
    Recovering
}


public interface IPet
{
    PetFood FoodType { get; set; }
    PetStatus HealthStatus { get; set; }
    AnimalType AnimalType { get; set; }
    string Breed { get; set; }



}

public class Pet : Product, IPet 
{
    [Required]
    public PetFood FoodType { get; set; }
    public PetStatus HealthStatus { get; set; }
    public AnimalType AnimalType { get; set; }
    public string Breed { get; set; }
    public Transaction Transactions { get; set; }


    public Pet()
	{
        FoodType = new PetFood();
    }
}

