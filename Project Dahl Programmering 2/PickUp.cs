using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dahl_Programmering_2 {
	internal class PickUp : Booking{
		protected string StartDate;
		protected int StartTime;
		protected string EndDate;
		protected int EndTime;
		protected string PickUpLocation;

		public PickUp(string inputStartDate, int inputStartTime, string inputEndDate, int inputEndTime, string inputPickUpLocation, string inputName, int inputAge, string inputEmail, string inputPhoneNumber, string inputAdress) :base(inputName, inputAge, inputEmail, inputPhoneNumber, inputAdress) {
			StartDate = inputStartDate;
			StartTime = inputStartTime;
			EndDate = inputEndDate;
			EndTime = inputEndTime;
			PickUpLocation = inputPickUpLocation;
		}
	}
}
