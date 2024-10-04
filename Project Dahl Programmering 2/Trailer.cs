using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dahl_Programmering_2 {
	internal class Trailer : VehicleInfo{
		protected string TrailerType;
		protected int MaxWeight;
		protected int Volume;
		protected string Braked;

		public Trailer(string inputTrailerType, int inputMaxWeight, int inputVolume, string inputBraked, string inputVehiceInfo, string inputFuelInfo, int inputTyres) : base(inputVehiceInfo, inputFuelInfo, inputTyres) {
			TrailerType = inputTrailerType;
			MaxWeight = inputMaxWeight;
			Volume = inputVolume;
			Braked = inputBraked;
		}

		List<Trailer> trailerList = new List<Trailer> {
			new Trailer("Enclosed Trailer", 1000, 5, "Braked", "trailer", "NO FUEL", 2),
			new Trailer("Grtaing Trailer", 500, 2, "Unbraked", "trailer", "NO FUEL", 2)
		};
	}
}
