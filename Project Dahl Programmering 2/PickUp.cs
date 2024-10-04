using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dahl_Programmering_2 {
	internal class PickUp : Booking{
		public DateTime Start;
		public DateTime End;
		public string PickUpLocation;

		public PickUp(DateTime inputStart, DateTime inputEnd, string inputPickUpLocation, string inputName, int inputAge, string inputEmail, string inputPhoneNumber, string inputAdress) :base(inputName, inputAge, inputEmail, inputPhoneNumber, inputAdress) {
			Start = inputStart;
			End = inputEnd;
			PickUpLocation = inputPickUpLocation;
		}
	}
}
