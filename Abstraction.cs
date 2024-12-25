using System;

abstract class Vehicle
{
    public Vehicle()
    {
        Console.WriteLine("Vehicle created.");
    }

    static Vehicle()
    {
        Console.WriteLine("Vehicle type created.");
    }
    public Vehicle(int number)
    {
        Console.WriteLine("Vehicle created with number.");
    }
    public abstract void StartEngine();
    public void Honk()
    {
        Console.WriteLine("Honk honk!");
    }
}
class Car : Vehicle
{
    public Car()
    {
        Console.WriteLine("Car created. in sub class");
    }
    public Car(int number) : base(number)
    {
        Console.WriteLine("Car created with number.");
    }

    public override void StartEngine()
    {
        Console.WriteLine("Car engine started.");
    }
}

class Bike : Vehicle
{
    public Bike(int number) : base(number)
    {
        Console.WriteLine("Bike created with number.");
    }
    public override void StartEngine()
    {
        Console.WriteLine("Bike engine started.");
    }
}

class Program1
{
    static void Main2(string[] args)
    {
         Vehicle car1 = new Car();
        Vehicle car = new Car(1);
        Vehicle bike = new Bike(2);

        StartEngine(car);
        StartEngine(car1);
        StartEngine(bike);

    }

    static void StartEngine(Vehicle vehicle)
    {
        vehicle.StartEngine();
        vehicle.Honk();
    }
}

