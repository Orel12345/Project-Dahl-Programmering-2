using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dahl_Programmering_2 {
	internal class VehicleInfo {
		public string BodyType;
		public string FuelType;
		public string Transmission;

		public VehicleInfo(string inputBodyType, string inputFuelType, string inputTransmission) {
			BodyType = inputBodyType;
			FuelType = inputFuelType;
			Transmission = inputTransmission;

		}

		public void SkipToCarInfo() {
			if (FuelType == "Electric") {
				
			}
		}



		public void PrintVehicleInfo() {
            Console.WriteLine("Your car body type: " + BodyType + " FuelType: " + " Transmission: " + Transmission);
        }
	}
}
