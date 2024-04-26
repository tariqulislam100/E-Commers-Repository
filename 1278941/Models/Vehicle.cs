using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1278941.Models
{
    public class Vehicle : BaseVehicleEntity
    {
        public Vehicle()
        {
        }

        public Vehicle(int id,string model, string manufacturer,int year, decimal price, int stock, int categoryic) : base(id)
        {
            this.Id = id;
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Year = year;
            this.Price = price;
            this.Stock = stock;
        }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
    }
}
