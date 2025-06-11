using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    public class CarLot
    {
        public List<Car> Cars { get; set; } = new List<Car>();

        public void AddCar(Car car)
        {
            if (car.IsDriveable)
            {
                Cars.Add(car);
                Console.WriteLine($"{car.Make} {car.Model} added to lot.");
            }
            else
            {
                Console.WriteLine($"{car.Make} {car.Model} is not driveable. Add anyway? (y/n)");
                string response = Console.ReadLine()?.ToLower();
                if (response == "y")
                {
                    Cars.Add(car);
                    Console.WriteLine($"{car.Make} {car.Model} added manually.");
                }
                else
                {
                    Console.WriteLine($"{car.Make} {car.Model} not added.");
                }
            }
        }

        public void ShowDriveableCars()
        {
            Console.WriteLine("\n--- Driveable Cars in the Lot ---");
            foreach (var car in Cars)
            {
                if (car.IsDriveable)
                {
                    Console.WriteLine($"{car.Year} {car.Make} {car.Model}");
                }
            }
        }
    }

}    