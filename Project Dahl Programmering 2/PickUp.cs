using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dahl_Programmering_2 {
	internal class PickUp {
		public DateTime Start;
		public DateTime End;
		public string PickUpLocation;

		public PickUp(DateTime inputStart, DateTime inputEnd, string inputPickUpLocation) {
			Start = inputStart;
			End = inputEnd;
			PickUpLocation = inputPickUpLocation;
		}
	}
}
