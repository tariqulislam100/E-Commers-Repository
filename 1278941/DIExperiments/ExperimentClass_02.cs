using _1278941.Factories;
using _1278941.Models;
using _1278941.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1278941.DIExperiments
{
    public class ExperimentClass_02
    {
        public void Run(IRepositoryFactory repositoryFactory)
        {
            IRepository<VehicleType> category = repositoryFactory.CreateRepository<VehicleType>();
            category.AddRange(new VehicleType[]
            {
                new VehicleType{ Id=1, Name="Four Wheeler"},
                new VehicleType{ Id=2, Name="Two Wheeler"},
                new VehicleType{ Id=3, Name="Water Vehicle"},
                new VehicleType{ Id=4, Name="Air Vehicle"},
                new VehicleType{ Id=5, Name="Public Transport Vehicle"}
            });
            //Get All Product:
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~GetAll~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();
            category.GetAll().ToList()
           .ForEach(c => Console.WriteLine($"Id: {c.Id}, Name: {c.Name}"));
            //Get Product By Id:
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Get~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();
            var cat = category.Get(3);
            Console.WriteLine($"Id: {cat.Id}, Name: {cat.Name}");
            //Update Product:
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Update~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();
            cat.Name = "Ambulance";
            category.Update(cat);
            category.GetAll().ToList()
           .ForEach(c => Console.WriteLine($"Id: {c.Id}, Name: {c.Name}"));
            //Delete Product:
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~Delete~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();
            category.Delete(3);
            category.GetAll().ToList()
           .ForEach(c => Console.WriteLine($"Id: {c.Id}, Name: {c.Name}"));
            Console.WriteLine();
            Console.WriteLine("****************************!!!!!!!!!!!!!!!!!!!!!!!!!!!*****************************************");
            Console.WriteLine();
            IRepository<Vehicle> vehicle = repositoryFactory.CreateRepository<Vehicle>();
            vehicle.AddRange(new Vehicle[]
              {
                new Vehicle{ Id=1,Manufacturer="Toyota Motor corp", Model="Toyota Corolla",Year=1977, Price=7500000.00M, Stock=30, CategoryId=1},
                new Vehicle{ Id=2, Manufacturer="Honda Motor Co Ltdo",Model="BMW M 1000 R",Year=1987, Price=270000.00M, Stock=130, CategoryId=2},
                new Vehicle{ Id=3, Manufacturer="EU Shipping Corp",Model="Titanic",Year=1997, Price=500000000.00M, Stock=5, CategoryId=3},
                new Vehicle{ Id=4, Manufacturer="Airbus CO Ltd",Model="Airbus A330",Year=1967, Price=50000000.00M, Stock=10, CategoryId=4},
                new Vehicle{ Id=5,Manufacturer="Tata Motors", Model="BRTC A12", Year = 1971, Price=2200000.00M, Stock=300, CategoryId=5}
              });
            //Get All Product:
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^GetAll^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine();
            vehicle.GetAll().ToList()
           .ForEach(v => Console.WriteLine($"Id:{v.Id}, Manufacturer:{v.Manufacturer} Name: {v.Model},Year Make:{v.Year} Price: {v.Price}, Stock: {v.Stock}"));
            //Get Product By Id:
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Get^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine();
            var vehicles = vehicle.Get(2);
            Console.WriteLine($"Id:{vehicles.Id}, Name: {vehicles.Model}, Price: {vehicles.Price}, Stock: {vehicles.Stock}");
            //Update Product:
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Update^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine();
            vehicles.Price = 20030900;
            vehicle.Update(vehicles);
            vehicle.GetAll().ToList()
           .ForEach(p => Console.WriteLine($"Id:{p.Id}, Name: {p.Model}, Price: {p.Price}, Stock: {p.Stock}"));
            //Delete Product:
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^Delete^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine();
            vehicle.Delete(2);
            vehicle.GetAll().ToList()
           .ForEach(p => Console.WriteLine($"Id:{p.Id}, Name: {p.Model}, Price: {p.Price}, Stock: {p.Stock}"));
        }
    }
}
