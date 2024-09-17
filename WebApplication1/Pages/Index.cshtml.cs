using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {
        public Vehicle Vehicle { get; set; }
        public Truck Truck { get; set; }
        public List<Truck> Trucks { get; set; }

        public void OnGet()
        {
            Vehicle = new Vehicle("Toyota", "Corolla", 2020);
            Truck = new Truck("Ford", "F-150", 2022, 1000, "Diesel");
            Trucks = new List<Truck>();
        }

        public void OnPost(Truck truck)
        {
            Trucks.Add(truck);
        }
    }

    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }
    }

    public class Truck : Vehicle
    {
        public int LoadCapacity { get; set; }
        public string FuelType { get; set; }

        public Truck(string brand, string model, int year, int loadCapacity, string fuelType)
            : base(brand, model, year)
        {
            LoadCapacity = loadCapacity;
            FuelType = fuelType;
        }
    }
}