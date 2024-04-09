using System;
namespace InterfaceExercise
{
	internal class SUV : IVehicle, ICompany
	{
        public int NumberOfSeats { get; set; }
        public bool HasFourWheelDrive { get; set; }

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
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Does it have engine?{HasEngine}");
            Console.WriteLine($"Fords logo: {Logo}");
            Console.WriteLine($"HeadQuater: {HeadQuater}");
            Console.WriteLine($"How many seats? {NumberOfSeats}");
            Console.WriteLine($"Has fourwheel Drive? {HasFourWheelDrive}");
            Console.WriteLine();

        }



    }
    







}


