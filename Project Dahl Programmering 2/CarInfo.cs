using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dahl_Programmering_2 {
	internal class CarInfo : VehicleInfo {
		public string BodyType;
		public string Transmission;
		protected int HorsePower;
		protected int TowCapacity;
		protected int Doors;

		public CarInfo(int inputHorsePower, int inputTowCapacity, int inputDoors, string inputBodyType, string inputFuelInfo, string inputTransmission, string inputVehiceInfo, int inputTyres) : base(inputVehiceInfo, inputFuelInfo, inputTyres) {
			Transmission = inputTransmission;
			BodyType = inputBodyType;
			FuelInfo = inputFuelInfo;
			HorsePower = inputHorsePower;
			TowCapacity = inputTowCapacity;
			Doors = inputDoors;
		}

		List<CarInfo> AvailableCarsList = new List<CarInfo>() {
			new CarInfo(250, 800, 4, "Sedan", "Petrol", "Automatic", "Car", 4),
			new CarInfo(250, 650, 4, "Sedan", "Diesel", "Manual", "car", 4),
			new CarInfo(250, 500, 4, "Sedan", "Electric", "Automatic", "car", 4),

			new CarInfo(300, 950, 4, "Suv", "Petrol", "Automatic", "car", 4),
			new CarInfo(250, 1000, 4, "Suv", "Diesel", "Manual", "car", 4),
			new CarInfo(450, 800, 4, "Suv", "Electric", "Automatic", "car", 4),

			new CarInfo(400, 1000, 4, "Kombi", "Petrol", "Automatic", "car", 4),
			new CarInfo(250, 600, 4, "Kombi", "Diesel", "Manual", "car", 4),
			new CarInfo(350, 750, 4, "Kombi", "Electric", "Automatic", "car", 4),

			new CarInfo(500, 0, 2, "Sport", "Petrol", "Automatic", "car", 4),
			new CarInfo(600, 0, 2, "Sport", "Diesel", "Manual", "car", 4),
			new CarInfo(700, 0, 2, "Sport", "Electric", "Automatic", "car", 4),

		};

		public List<CarInfo> MethodOfElimination(string inputBodyType, string inputTransmission, string inputFuelType) {
			List<CarInfo> AvailableCars = new List<CarInfo>();
			for (int i = 0; i <= AvailableCarsList.Count; i++) {
				if (AvailableCarsList[i].BodyType == inputBodyType && AvailableCarsList[i].Transmission == inputTransmission && AvailableCarsList[i].FuelType == inputFuelType) {
					AvailableCars.Add(AvailableCarsList[i]);
				}
			}
			return AvailableCars;





		}
	}
}
