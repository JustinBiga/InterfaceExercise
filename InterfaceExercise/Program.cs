using System;
using System.Collections.Generic;
using InterfaceExercise;


// Creating objects of Car, Truck, and SUV classes
Car myCar = new Car
{
    Manufacturer = "BMW AG",
    BodyType = "Coupe",
    Year = 2024,
    Make = "BMW",
    Model = "M4",
    HasEngine = true,
    Logo = "Bavarian flag",
    HeadQuater = "Munich",
};

Truck truck1 = new Truck
{
    HasTrailer = true,
    CargoCapacity = 12000,
    Year = 2024,
    Make = "Toyota",
    Model = "Tundra",
    HasEngine = true,
    Logo = "Two ovals",
    HeadQuater = "Aichi Japan",
};

SUV Suv1 = new SUV
{
    NumberOfSeats = 8,
    HasFourWheelDrive = true,
    Year = 2024,
    Make = "Ford",
    Model = "Expedition",
    HasEngine = true,
    Logo = "Flattened oval",
    HeadQuater = "Dearborn MI",

};

List<IVehicle> vehicles = new List<IVehicle>();

vehicles.Add(myCar);
vehicles.Add(truck1);
vehicles.Add(Suv1);

foreach (IVehicle item in vehicles)
{
    item.DisplayDetails();
    Console.WriteLine();
}
