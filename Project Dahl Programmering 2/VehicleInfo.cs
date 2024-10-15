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

		/// <summary>
		/// En konstruktor som tar emot värden på vehicletype, tyres och info
		/// </summary>
		/// <param name="inputVehiceInfo"></param>
		/// <param name="inputFuelInfo"></param>
		/// <param name="inputTyres"></param>

		public VehicleInfo(string inputVehiceInfo, string inputFuelInfo, int inputTyres) {
			VehicleType = inputVehiceInfo;
			Tyres = inputTyres;
			FuelInfo = inputFuelInfo;
		}




	}
}
