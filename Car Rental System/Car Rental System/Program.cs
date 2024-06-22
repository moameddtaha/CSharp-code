namespace Car_Rental_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] cars =
            {
                new Car (1, "Totyota", "Corolla", 50, true),
                new Car(2, "Honda", "Civic", 60, true),
                new Car(3, "Ford", "Mustang", 80, true)
            };


            Console.WriteLine("Welcome to the car rental system!\n");

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("----------------------------------------------------------");

                foreach (var car in cars)
                {
                    if (car.IsAvailable)
                    {
                        Console.WriteLine($"{car} - Available.");
                    }
                    else if (!car.IsAvailable)
                    {
                        Console.WriteLine($"{car} - Rented.");
                    }
                }

                Console.WriteLine("");
                Console.WriteLine("Menu");
                Console.WriteLine("1. Rent a car");
                Console.WriteLine("2. Return a car");
                Console.WriteLine("3. View available cars");
                Console.WriteLine("4. Exit");

                Console.Write("\nPlease enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("");
                        Console.WriteLine("Rent a car:");
                        Console.WriteLine("Please enter the ID of the car that you want to rent.");

                        int carIdToRent = int.Parse(Console.ReadLine());

                        foreach (var car in cars)
                        {
                            if (car.Id == carIdToRent)
                            {
                                car.Rent();
                                
                                break;
                            }
                            
                        }

                        break;

                    case "2":
                        Console.WriteLine("Return a Car:");

                        Console.Write("Please enter the ID of the car you want to return: ");
                        int carIdToReturn = int.Parse(Console.ReadLine());
                        
                        foreach (Car car in cars)
                        {
                            if (car.Id == carIdToReturn)
                            {
                                car.Return();
                                
                                break;
                            }
                        }

                        break;

                    case "3":
                        Console.WriteLine("Available cars:");

                        bool allCarsRented = true;
                        foreach (Car car in cars)
                        {
                            if (car.IsAvailable)
                            {
                                Console.WriteLine(car + " - Available");
                                allCarsRented = false;
                            }
                            else
                            {
                                Console.WriteLine(car + " - Rented");
                            }
                        }

                        if (allCarsRented)
                        {
                            Console.WriteLine("All cars are currently rented.\n");
                        }

                        break;

                    case "4":
                        Console.WriteLine("Thank you for using the car rental system!");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.\n");
                        
                        break;

                }

            }

        }
    }
}
