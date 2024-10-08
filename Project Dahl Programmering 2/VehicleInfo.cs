using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dahl_Programmering_2 {
	internal class VehicleInfo {
		public string VehicleType;
		public int Tyres;
		public string FuelInfo;

		public VehicleInfo(string inputVehiceInfo, string inputFuelInfo, int inputTyres) {
			VehicleType = inputVehiceInfo;
			Tyres = inputTyres;
			FuelInfo = inputFuelInfo;
		}




	}
}
