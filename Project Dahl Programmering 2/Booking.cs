using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dahl_Programmering_2 {
	internal class Booking {
		private string _name;
		private int _age;
		private string _email;
		private string _phoneNumber;
		private string _adress;

		/// <summary>
		/// Konstruktor som tar emot värden från fälten name, age, email, phone number, adress
		/// </summary>
		/// <param name="inputName">Tar emot info om namn</param>
		/// <param name="inputAge">Tar emot info om ålder</param>
		/// <param name="inputEmail">Tar emot info om email</param>
		/// <param name="inputPhoneNumber">Tar emot info om mobilnummer</param>
		/// <param name="inputAdress">Tar emot info om adressen</param>

		public Booking (string inputName, int inputAge, string inputEmail, string inputPhoneNumber, string inputAdress) {
			_name = inputName;
			_age = inputAge;
			_email = inputEmail;
			_phoneNumber = inputPhoneNumber;
			_adress = inputAdress;
		}

		/// <summary>
		/// hämtar _name och returnerar den samt att den sätts som value
		/// </summary>

		public string Name {
			get {
				return _name;
			}

			set {
			  _name = value;
			}
		}

		/// <summary>
		/// hämtar _age och returnerar den samt att den sätts som value
		/// </summary>

		public int Age {
			get {
				return _age;
			}

			set {
				_age = value;
			}
		}

		/// <summary>
		/// hämtar _email och returnerar den samt att den sätts som value
		/// </summary>

		public string Email {
			get {
				return _email;
			}

			set {
				_email = value;
			}
		}

		/// <summary>
		/// hämtar _phoneNumber och returnerar den samt att den sätts som value
		/// </summary>

		public string PhoneNumber {
			get {
				return _phoneNumber;
			}

			set {
				_phoneNumber = value;
			}
		}

		/// <summary>
		/// hämtar _adress och returnerar den samt att den sätts som value
		/// </summary>

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
