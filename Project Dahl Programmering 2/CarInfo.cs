using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dahl_Programmering_2 {
	internal class CarInfo : VehicleInfo {
		public string BodyType;
		public string Transmission;
		public int HorsePower;
		public int TowCapacity;
		public int Doors;
		public string CarModel;

		/// <summary>
		/// Konstruktor som tar emot värden från fälten bodytype, transmission, horse power, tow capacity, doors, car model
		/// </summary>
		/// <param name="inputCarModel">Tar emot info om car model</param>
		/// <param name="inputHorsePower">Tar emot info om horse power</param>
		/// <param name="inputTowCapacity">Tar emot info om tow capacity</param>
		/// <param name="inputDoors">Tar emot info om antalet dörrar</param>
		/// <param name="inputBodyType">Tar emot info om karrosen</param>
		/// <param name="inputFuelInfo">Tar emot info om bränslet</param>
		/// <param name="inputTransmission">Tar emot info om växel låda</param>
		/// <param name="inputVehiceInfo">Tar emot info om vehicle</param>
		/// <param name="inputTyres">Tar emot info om antal däck</param>

		public CarInfo(string inputCarModel, int inputHorsePower, int inputTowCapacity, int inputDoors, string inputBodyType, string inputFuelInfo, string inputTransmission, string inputVehiceInfo, int inputTyres) : base(inputVehiceInfo, inputFuelInfo, inputTyres) {
			Transmission = inputTransmission;
			BodyType = inputBodyType;
			FuelInfo = inputFuelInfo;
			HorsePower = inputHorsePower;
			TowCapacity = inputTowCapacity;
			Doors = inputDoors;
			CarModel = inputCarModel;

		}

		static List<CarInfo> AvailableCarsList = new List<CarInfo>() {
			new CarInfo("Kia", 250, 800, 4, "Sedan", "Petrol", "Automatic", "Car", 4),
			new CarInfo("Rolls royce", 250, 800, 4, "Sedan", "Petrol", "Manual", "Car", 4),
			new CarInfo("Mazda", 250, 650, 4, "Sedan", "Diesel", "Automatic", "car", 4),
			new CarInfo("Nissan", 250, 650, 4, "Sedan", "Diesel", "Manual", "car", 4),
			new CarInfo("Volvo", 250, 500, 4, "Sedan", "Electric", "Automatic", "car", 4),

			new CarInfo("Toyota", 300, 950, 4, "Suv", "Petrol", "Automatic", "car", 4),
			new CarInfo("Volkswagen", 300, 950, 4, "Suv", "Petrol", "Manual", "car", 4),
			new CarInfo("Jeep",250, 1000, 4, "Suv", "Diesel", "Manual", "car", 4),
			new CarInfo("Ford",250, 1000, 4, "Suv", "Diesel", "Automatic", "car", 4),
			new CarInfo("Tesla",450, 800, 4, "Suv", "Electric", "Automatic", "car", 4),

			new CarInfo("Mini cooper", 400, 1000, 4, "Kombi", "Petrol", "Automatic", "car", 4),
			new CarInfo("Audi", 400, 1000, 4, "Kombi", "Petrol", "Manual", "car", 4),
			new CarInfo("BMW", 250, 600, 4, "Kombi", "Diesel", "Manual", "car", 4),
			new CarInfo("Honda", 250, 600, 4, "Kombi", "Diesel", "Automatic", "car", 4),
			new CarInfo("Mercedes", 350, 750, 4, "Kombi", "Electric", "Automatic", "car", 4),

			new CarInfo("Lamborghini", 500, 0, 2, "Sport", "Petrol", "Automatic", "car", 4),
			new CarInfo("Ferrari", 500, 0, 2, "Sport", "Petrol", "Manual", "car", 4),
			new CarInfo("Porsche", 600, 0, 2, "Sport", "Diesel", "Manual", "car", 4),
			new CarInfo("Dodge SRT Hellcat", 600, 0, 2, "Sport", "Diesel", "Automatic", "car", 4),
			new CarInfo("Porsche Taycan", 700, 0, 2, "Sport", "Electric", "Automatic", "car", 4),

		};

		/// <summary>
		/// Metod som utesluter allt som användaren inte har valt för att till slut ha en bil kvar.
		/// </summary>
		/// <param name="inputBodyType">Vilken karosstyp användaren valde</param>
		/// <param name="inputTransmission">Växellådan användaren valde</param>
		/// <param name="inputFuelInfo">Vilket bränsle användaren valde</param>
		/// <returns>Den bilen som finns kvar</returns>

		public static List<CarInfo> MethodOfElimination(string inputBodyType, string inputTransmission, string inputFuelInfo) {
			Console.WriteLine(inputBodyType);
			Console.WriteLine(inputFuelInfo);
			Console.WriteLine(inputTransmission);
			List<CarInfo> AvailableCars = new List<CarInfo>();
			for (int i = 0; i < AvailableCarsList.Count; i++) {
				if (AvailableCarsList[i].BodyType == inputBodyType && AvailableCarsList[i].FuelInfo == inputFuelInfo || AvailableCarsList[i].Transmission == inputTransmission) {
					AvailableCars.Add(AvailableCarsList[i]);
                    
                }
			}

			
			return AvailableCars;







		}
	}
}
