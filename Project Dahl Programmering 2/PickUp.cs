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

		/// <summary>
		/// Tar info om när användaren vill hämta sin bill
		/// </summary>
		/// <param name="inputStart">start datumet</param>
		/// <param name="inputEnd">slut datumet</param>
		/// <param name="inputPickUpLocation">vart man vill hämta bilen</param>

		public PickUp(DateTime inputStart, DateTime inputEnd, string inputPickUpLocation) {
			Start = inputStart;
			End = inputEnd;
			PickUpLocation = inputPickUpLocation;
		}
	}
}
