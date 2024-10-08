using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dahl_Programmering_2 {
	internal class UserInterface {

		public void StartPage() {
            Console.WriteLine("Welcome to Orel's Rental Cars");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Press any key to continue");
			Console.ReadKey();
			Console.Clear();

		}

        public void BookingDetails() {
            Console.WriteLine("Please write your first and last name");
            string inputName = Console.ReadLine();
            while (inputName == "") {
                Console.WriteLine("Invalid input, please try again");
                inputName = Console.ReadLine();
               
            }

			Console.Clear();

			Console.WriteLine("Please write your age");
			string inputAge = Console.ReadLine();
            int age;
			while (!int.TryParse(inputAge, out age)) {
				Console.WriteLine("Invalid input, please try again");
				inputAge = Console.ReadLine();
				
			}

            if (age < 18) {
                Environment.Exit(1);
            }

			Console.Clear();

			Console.WriteLine("Please write your email");
			string inputEmail = Console.ReadLine();
			while (inputEmail == "") {
				Console.WriteLine("Invalid input, please try again");
				inputEmail = Console.ReadLine();

			}

            Console.Clear();

			Console.WriteLine("Please write your phone number");
			string inputPhoneNumber = Console.ReadLine();
			while (inputPhoneNumber == "") {
				Console.WriteLine("Invalid input, please try again");
				inputPhoneNumber = Console.ReadLine();

			}

            Console.Clear();

			Console.WriteLine("Please write your adress");
			string inputAdress = Console.ReadLine();
			while (inputAdress == "") {
				Console.WriteLine("Invalid input, please try again");
				inputAdress = Console.ReadLine();

			}
		}

        public void PickUpInfo() {
            Console.WriteLine("When would you like to pick up your car?");
            string startTimeInput = Console.ReadLine();
            Console.WriteLine("When would you like to leave your car?");
            string endTimeInput = Console.ReadLine();

            DateTime start = DateTime.ParseExact(startTimeInput, "d MMMM", CultureInfo.InvariantCulture);
			DateTime end = DateTime.ParseExact(endTimeInput, "d MMMM", CultureInfo.InvariantCulture);

            Console.WriteLine("Where would you like to pick the car up. Choose between Stockholm, Malmö and Gothenburg");

            string LocationInput = Console.ReadLine();



        }


		public void MainPageBodyType() {
            Console.WriteLine("Which of the following car bodytypes would you like?");
            Console.WriteLine("1. Sedan");
            Console.WriteLine("2. Suv");
            Console.WriteLine("3. Kombi");
            Console.WriteLine("4. Sport");
            string inputBodyType = Console.ReadLine();
            int numChoice;

            while(!int.TryParse(inputBodyType, out numChoice)) {
                Console.WriteLine("Please write a number");
                inputBodyType = Console.ReadLine();
            }

            if (numChoice == 1) {
                MainPageFuelType();
            } else if (numChoice == 2) {
                MainPageFuelType();
            } else if (numChoice == 3) {
                MainPageFuelType();
            } else if (numChoice == 4) {
                MainPageFuelType();
            }

        }

        public void MainPageFuelType() {
			Console.Clear();
			Console.WriteLine("Which fueltype would you like on your car?");
			Console.WriteLine("1. Petrol");
			Console.WriteLine("2. Diesel");
			Console.WriteLine("3. Electric");
            string inputFuelType = Console.ReadLine();
            int numChoice;

			while (!int.TryParse(inputFuelType, out numChoice)) {
				Console.WriteLine("Please write a number");
				inputFuelType = Console.ReadLine();
			}
			if (numChoice == 1) {
                MainPageTransmission();
            } else if (numChoice == 2) {
                MainPageTransmission();
            } else if (numChoice == 3) {
                MainPageTrailer();
            }


		}

        public void MainPageTransmission() {
            Console.Clear();
            Console.WriteLine("Which transmission would you like ?");
            Console.WriteLine("1. Manual");
            Console.WriteLine("2. Automatic");
            string inputTransmission = Console.ReadLine();
            int numChoice;
			while (!int.TryParse(inputTransmission, out numChoice)) {
				Console.WriteLine("Please write a number");
				inputTransmission = Console.ReadLine();
			}
			if  (numChoice == 1) {
                MainPageTrailer();
            } else if (numChoice == 2) {
                MainPageTrailer();
            }

        }

        public void MainPageTrailer() {
            Console.Clear();
            Console.WriteLine("Would you like a trailer?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
			string inputTrailer = Console.ReadLine();
			int numChoice;
            while(!int.TryParse(inputTrailer, out numChoice)) {
                Console.WriteLine("Please write a number");
                inputTrailer = Console.ReadLine();
            }

            if (numChoice == 1) {
                Console.WriteLine("Which trailer would you like?");
                Console.WriteLine("1. Enclosed Trailer");
                Console.WriteLine("2. Grating trailer");
				string inputTrailerType = Console.ReadLine();
				int numChoiceTrailer;
				while (!int.TryParse(inputTrailerType, out numChoiceTrailer)) {
					Console.WriteLine("Please write a number");
					inputTrailerType = Console.ReadLine();
				}

			} else if (numChoice == 2) {

            }


		}

        public void LastInfo() {

        }
	}
}
