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

		public Trailer(string inputTrailerType, int inputMaxWeight, int inputVolume, string inputBraked, string inputBodyType, string inputFuelType, string inputTransmission) : base(inputBodyType, inputFuelType, inputTransmission) {
			TrailerType = inputTrailerType;
			MaxWeight = inputMaxWeight;
			Volume = inputVolume;
			Braked = inputBraked;
		}
	}
}
