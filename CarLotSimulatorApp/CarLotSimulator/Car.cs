using System;
namespace CarLotSimulator;

public class Car
{

    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string EngineNoise { get; set; }
    public string HonkNoise { get; set; }
    public bool IsDriveable { get; set; }

    public Car()
    {
        CarLot.numberOfCars++;
    }

    public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
    {
        Year = year;
        Make = make;
        Model = model;
        EngineNoise = engineNoise;
        HonkNoise = honkNoise;
        IsDriveable = isDriveable;

        CarLot.numberOfCars++;
    }

    public void MakeEngineNoise(string noise)
    {
        Console.WriteLine($"Engine goes: {noise}");
    }

    public void MakeHonkNoise(string noise)
    {
        Console.WriteLine($"Honk goes: {noise}");
    }
}