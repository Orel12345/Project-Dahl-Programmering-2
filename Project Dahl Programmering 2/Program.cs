using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dahl_Programmering_2 {
	internal class Program {
		static void Main(string[] args) {
			UserInterface userInterface = new UserInterface();

			userInterface.StartPage();
			userInterface.BookingDetails();
			userInterface.PickUpInfo();
		}
	}
}
