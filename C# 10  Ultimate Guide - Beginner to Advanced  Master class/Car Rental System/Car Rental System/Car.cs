using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Car_Rental_System
{
    internal class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public double RentalPrice { get; set; }
        public bool IsAvailable { get; set; } = true;

        public Car() { }

        public Car(int id, string make, string model, double rentalPrice, bool isAvailable)
        {
            Id = id;
            Make = make;
            Model = model;
            RentalPrice = rentalPrice;
            IsAvailable = isAvailable;
        }

        public bool Rent()
        {
            if (IsAvailable)
            {
                Console.WriteLine($"{this.Id} Rented successfully :)");
                IsAvailable = false;
                return true;
            }
            else
            {
                Console.WriteLine("We're sorry the car is currently rented :(");
                return false;
            }
        }

        public bool Return()
        {
            if (IsAvailable == false)
            {
                Console.WriteLine($"{this.Id} Returned successfully :)");
                IsAvailable = true;
                return true;
            }
            else
            {
                Console.WriteLine("The car is already available :(");
                return false;
            }
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Make)}: {Make}, {nameof(Model)}: {Model}, {nameof(RentalPrice)}: {RentalPrice}";
        }
    }
}
