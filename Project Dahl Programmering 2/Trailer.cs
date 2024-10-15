using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dahl_Programmering_2 {
	internal class Trailer : VehicleInfo{
		public string TrailerType;
		public int MaxWeight;
		public int Volume;
		public string Braked;

		public Trailer(string inputTrailerType, int inputMaxWeight, int inputVolume, string inputBraked, string inputVehiceInfo, string inputFuelInfo, int inputTyres) : base(inputVehiceInfo, inputFuelInfo, inputTyres) {
			TrailerType = inputTrailerType;
			MaxWeight = inputMaxWeight;
			Volume = inputVolume;
			Braked = inputBraked;
		}

		static List<Trailer> trailerList = new List<Trailer> {
			new Trailer("Enclosed Trailer", 1000, 5, "Braked", "trailer", "NO FUEL", 2),
			new Trailer("Grating Trailer", 500, 2, "Unbraked", "trailer", "NO FUEL", 2)
		};
	}
}
