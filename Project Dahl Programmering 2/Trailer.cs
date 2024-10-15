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

		/// <summary>
		/// Konstruktor som tar emot värden från fälten Trailertype, Max weight, volume, braked
		/// </summary>
		/// <param name="inputTrailerType">Tar emot info om Trailer type</param>
		/// <param name="inputMaxWeight">Tar emot info om max vikt</param>
		/// <param name="inputVolume">Tar emot info om volymen</param>
		/// <param name="inputBraked">Tar emot info om bromsad släp eller inte</param>
		/// <param name="inputVehiceInfo">Tar emot info om vehicle</param>
		/// <param name="inputFuelInfo">Tar emot info om bränsle</param>
		/// <param name="inputTyres">Tar emot info om antal däck</param>

		public Trailer(string inputTrailerType, int inputMaxWeight, int inputVolume, string inputBraked, string inputVehiceInfo, string inputFuelInfo, int inputTyres) : base(inputVehiceInfo, inputFuelInfo, inputTyres) {
			TrailerType = inputTrailerType;
			MaxWeight = inputMaxWeight;
			Volume = inputVolume;
			Braked = inputBraked;
		}

		public static List<Trailer> trailerList = new List<Trailer> {
			new Trailer("Enclosed Trailer", 1000, 5, "Braked", "trailer", "NO FUEL", 2),
			new Trailer("Grating Trailer", 500, 2, "Unbraked", "trailer", "NO FUEL", 2)
		};
	}
}
