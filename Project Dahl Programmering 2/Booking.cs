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

		public string Name {
			get {
				return _name;
			}

			set {
			  _name = value;
			}
		}

		public int Age {
			get {
				return _age;
			}

			set {
				_age = value;
			}
		}

		public string Email {
			get {
				return _email;
			}

			set {
				_email = value;
			}
		}

		public string PhoneNumber {
			get {
				return _phoneNumber;
			}

			set {
				_phoneNumber = value;
			}
		}

		public string Adress {
			get {
				return _adress;
			}

			set {
				_adress = value;
			}
		}
	}
}
