using System;
namespace InterfaceExercise
{
	internal interface IVehicle
	{
		public int Year{ get; set; } 
		public string Make { get; set; }
		public string Model { get; set; }
		public bool HasEngine { get; set; }


		public void DisplayDetails();
		
		

    }


}

