using System;
using System.Collections.Generic;
using System.Linq;
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
                Console.WriteLine( );
            }
        }

		public void MainPageBodyType() {
            Console.WriteLine("Which of the following car bodytypes would you like?");
            Console.WriteLine("1. Sedan");
            Console.WriteLine("2. Suv");
            Console.WriteLine("3. Kombi");
            Console.WriteLine("4. Sport");
            string inputBodyType = Console.ReadLine();
            if (inputBodyType == "1") {
                MainPageFuelType();
            } else if (inputBodyType == "2") {
                MainPageFuelType();
            } else if (inputBodyType == "3") {
                MainPageFuelType();
            } else if (inputBodyType == "4") {
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
            if (inputFuelType == "1") {
                MainPageTransmission();
            } else if (inputFuelType == "2") {
                MainPageTransmission();
            } else if (inputFuelType == "3") {

            }


		}

        public void MainPageTransmission() {
            Console.Clear();
            Console.WriteLine("Which transmission would you like ?");
            Console.WriteLine("1. Manual");
            Console.WriteLine("2. Automatic");
            string inputTransmission = Console.ReadLine();
            if  (inputTransmission == "1") {

            } else if (inputTransmission == "2") {

            }

        }

        public void MainPageCarInfo() {
            Console.Clear();
            Console.WriteLine("How much horsepower would you like on your car");
            Console.WriteLine("1. 250 - 400");
            Console.WriteLine("2. 500 - 700 (sport cars only)");
            string inputHorsePower = Console.ReadLine();
            if (inputHorsePower == "1") {
                Console.WriteLine();
            }

        }

        public void MainPageTrailer() {
            Console.Clear();

        }
	}
}
