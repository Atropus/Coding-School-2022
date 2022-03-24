using Petshop.EF;
using PetShopLibrary.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PetShopLibrary
{
    public class PetShopManager
    {
        private const string FILE_NAME = "petShop.json";
        private PetShop _petShop;
        
        public PetShopManager()
        {
            Load();
        }


        public void Load()
        {
            //if (File.Exists(FILE_NAME))
            //{
            //    string text = File.ReadAllText(FILE_NAME, Encoding.UTF8);
            //    _petShop = JsonSerializer.Deserialize<PetShop>(text);
            //    return;
            //}

            _petShop = new PetShop();
            using var context = new PetShopContext();
            _petShop.Customers = context.Customers.ToList<Customer>();
            _petShop.Employees = context.Employees.ToList<Employee>();
            _petShop.Pets = context.Pets.ToList<Pet>();
            _petShop.PetFoods = context.PetsFood.ToList<PetFood>();
            _petShop.Transactions = context.Transactions.ToList<Transaction>();

        }

        public void Save(PetShopContext context)
        {
            
            context.SaveChanges();
            //string json = JsonSerializer.Serialize(_petShop);
            //File.WriteAllText(FILE_NAME, json);

        }

        public void Delete(Customer customer) 
        {
            using var context = new PetShopContext();
            Customer cust = (Customer)context.Customers.Where<Customer>(x => x.ID == customer.ID);
            if (cust is not null) return;
            cust.ObjectStatus = DataObjects.Status.Inactive;
            Save(context);
        }

        public void Delete(Employee employee)
        {
            using var context = new PetShopContext();
            Employee cust = (Employee)context.Employees.Where<Employee>(x => x.ID == employee.ID);
            if (cust is not null) return;
            cust.ObjectStatus = DataObjects.Status.Inactive;
            Save(context);
        }

        public void Delete(Pet pet)
        {
            using var context = new PetShopContext();
            Pet cust = (Pet)context.Pets.Where<Pet>(x => x.ID == pet.ID);
            if (cust is not null) return;
            cust.ObjectStatus = DataObjects.Status.Inactive;
            Save(context);
        }


        public void Delete(PetFood petFood)
        {
            using var context = new PetShopContext();
            PetFood cust = (PetFood)context.PetsFood.Where<PetFood>(x => x.ID == petFood.ID);
            if (cust is not null) return;
            cust.ObjectStatus = DataObjects.Status.Inactive;
            Save(context);
        }

        //public void DeletePetFoodRange(string brand, int qty)
        //{
        //    if(qty == 0) return;

        //    List<PetFood> petFoods = GetPetFoods().FindAll(x => x.Brand.Equals(brand) && x.ObjectStatus.Equals(Status.Active)).Take(qty).ToList();
        //    foreach(PetFood food in petFoods)
        //    {
        //        Delete(food);
        //    }
            
        //}


        public List<Customer> GetCustomers()
        {
            return _petShop.Customers;                
        }

        public List<Transaction> GetTransactions()
        {
            return _petShop.Transactions;
        }

        public List<Pet> GetPets()
        {
            return _petShop.Pets;
        }

        public List<PetFood> GetPetFoods()
        {
            return _petShop.PetFoods;
        }

        public List<Employee> GetEmployees()
        {
            return _petShop.Employees;
        }

        public void Add(Customer customer)
        {
            using var context = new PetShopContext();
            context.Customers.Add(customer);
            _petShop.Customers.Add(customer);
            Save(context);

        }

        public void Add(Employee employee)
        {
            using var context = new PetShopContext();
            context.Employees.Add(employee);
            _petShop.Employees.Add(employee);
            Save(context);
        }

        public void Add(Pet pet)
        {
            using var context = new PetShopContext();
            context.Pets.Add(pet);
            _petShop.Pets.Add(pet);
            Save(context);
        }

        public void Add(Transaction transaction)
        {
            using var context = new PetShopContext();
            context.Transactions.Add(transaction);
            _petShop.Transactions.Add(transaction);
            Save(context);
        }

        public void Add(PetFood petFood)
        {
            using var context = new PetShopContext();
            context.PetsFood.Add(petFood);
            _petShop.PetFoods.Add(petFood);
            Save(context);
        }

        public PetFood? GetFood(AnimalType type, string brand)
        {
            PetFood? food = this.GetPetFoods().Find(x => x.Brand == brand && this.GetFoodType(type) == x.Type && x.ObjectStatus == Status.Active);
            return food;
        }

        public List<string> GetAvailableFoodBrands(AnimalType type)
        {
            var brands = this.GetFoodBrand(type);
            var available = brands.FindAll(x => GetFood(type, x) != null);
            return available;
        }


        public List<string> GetFoodBrand(AnimalType type)
        {
            FoodBrands brand = new FoodBrands();
            if(type == AnimalType.Dog)
            {
                return brand.DogFoodBrands;
            }
            else if(type == AnimalType.Bird)
            {
                return brand.BirdFoodBrands;
            }
            else if(type == AnimalType.Rat)
            {
                return brand.RatFoodBrands;
            }
            else if(type== AnimalType.Fish)
            {
                return brand.FishFoodBrands;
            }
            else if(type == AnimalType.Turtle)
            {
                return brand.TurtleFoodBrands;
            }
            else if(type == AnimalType.Snake)
            {
                return brand.SnakeFoodBrands;
            }
            else if(type == AnimalType.Cat)
            {
                return brand.CatFoodBrands;
            }
            else return null;
        }

        public FoodType GetFoodType(AnimalType type)
        {
            if (type == AnimalType.Dog)
            {
                return FoodType.DogFood;
            }
            else if (type == AnimalType.Bird)
            {
                return FoodType.BirdFood;
            }
            else if (type == AnimalType.Rat)
            {
                return FoodType.RatFood;
            }
            else if (type == AnimalType.Fish)
            {
                return FoodType.FishFood;
            }
            else if (type == AnimalType.Turtle)
            {
                return FoodType.TurtleFood;
            }
            else if (type == AnimalType.Snake)
            {
                return FoodType.SnakeFood;
            }
            else
            {
                return FoodType.CatFood;
            }
            
        }

        public int GetAvailableFoodQty(string brand)
        {
            return GetPetFoods().FindAll(x => x.Brand == brand).Count();
        }

        public decimal GetTotalPrice(Pet pet, int qty)
        {
            return GetFoodPrice(pet) * (qty-1 >= 0 ? qty-1 : 0 ) + pet.Price;
        }
        public decimal GetFoodPrice(Pet pet)
        {
            PetFood? petFood = GetPetFoods().Find(x => x.Brand == pet.FoodType.Brand);
            if (petFood == null) return 0;

            return petFood.Price;
        }

    }
}
