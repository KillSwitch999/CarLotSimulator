using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot lot = new CarLot();

            Car car1 = new Car
            {
                Year = 2019,
                Make = "Chevrolet",
                Model = "Malibu",
                EngineNoise = "Whomp",
                HonkNoise = "Beep",
                IsDriveable = true
            };

            Car car2 = new Car();
            car2.Year = 2005;
            car2.Make = "Pontiac";
            car2.Model = "Vibe";
            car2.EngineNoise = "Grind";
            car2.HonkNoise = "Haaank";
            car2.IsDriveable = false;

            Car car3 = new Car(2023, "Audi", "RS5", "Purrr", "Toot", true);

            lot.AddCar(car1);
            lot.AddCar(car2);
            lot.AddCar(car3);

            // Show all engine/honk noises
            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);

            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);

            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);

            // Show driveable cars
            lot.ShowDriveableCars();

            // Final report
            Console.WriteLine($"\n Total Cars Created: {Car.numberOfCars}");
        }
    }
}