using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dahl_Programmering_2 {
	internal class Booking {
		private string _name;
		private int _age;
		private string _email;
		private string _phoneNumber;
		private string _adress;

		public Booking (string inputName, int inputAge, string inputEmail, string inputPhoneNumber, string inputAdress) {
			_name = inputName;
			_age = inputAge;
			_email = inputEmail;
			_phoneNumber = inputPhoneNumber;
			_adress = inputAdress;
		}
	}
}
