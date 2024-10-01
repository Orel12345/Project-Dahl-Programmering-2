using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dahl_Programmering_2 {
	internal class CarInfo : VehicleInfo {
		protected int HorsePower;
		protected int TowCapacity;
		protected int Doors;

		public CarInfo(int inputHorsePower, int inputTowCapacity, int inputDoors, string inputBodyType, string inputFuelType, string inputTransmission) : base(inputBodyType, inputFuelType, inputTransmission){
			HorsePower = inputHorsePower;
			TowCapacity = inputTowCapacity;
			Doors = inputDoors;
		}

		List<CarInfo> AvailableCars = new List<CarInfo>() {
			new CarInfo(250, 800, 4, "Sedan", "Petrol", "Automatic"),
			new CarInfo(250, 650, 4, "Sedan", "Diesel", "Manual"),
			new CarInfo(250, 500, 4, "Sedan", "Electric", "Automatic"),

			new CarInfo(300, 950, 4, "Suv", "Petrol", "Automatic"),
			new CarInfo(250, 1000, 4, "Suv", "Diesel", "Manual"),
			new CarInfo(450, 800, 4, "Suv", "Electric", "Automatic"),

			new CarInfo(400, 1000, 4, "Kombi", "Petrol", "Automatic"),
			new CarInfo(250, 600, 4, "Kombi", "Diesel", "Manual"),
			new CarInfo(350, 750, 4, "Kombi", "Electric", "Automatic"),

			new CarInfo(500, 0, 2, "Sport", "Petrol", "Automatic"),
			new CarInfo(600, 0, 2, "Sport", "Diesel", "Manual"),
			new CarInfo(700, 0, 2, "Sport", "Electric", "Automatic"),

		};



	}
}
