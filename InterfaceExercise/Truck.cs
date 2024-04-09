using System;
namespace InterfaceExercise
{
	internal class Truck :IVehicle, ICompany
	{
        public bool HasTrailer { get; set; }
        public int CargoCapacity { get; set; }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public bool HasEngine { get; set; }

        public string Logo { get; set; }
        public string HeadQuater { get; set; }


        public void DisplayDetails()
        {
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model:{Model}");
            Console.WriteLine($"Has engine? {HasEngine}");
            Console.WriteLine($"Company logo: {Logo}");
            Console.WriteLine($"HeadQuater: {HeadQuater}");
            Console.WriteLine($"Has a trailer? {HasTrailer}");
            Console.WriteLine($"Cargo capacity: {CargoCapacity}");
            Console.WriteLine();

        }

    }




}

