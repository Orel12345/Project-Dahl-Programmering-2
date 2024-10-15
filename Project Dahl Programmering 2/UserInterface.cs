using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dahl_Programmering_2 {
	internal class UserInterface {
		protected string VehicleType;
		protected int Tyres;
		protected string FuelInfo;

		protected string InputBodyType;
        protected string InputTransmission;
        protected string InputFuelInfo;
		protected int HorsePower;
		protected int TowCapacity;
		protected int Doors;
		protected string CarModel;

		protected string InputTrailerType;
		protected int MaxWeight;
		protected int Volume;
		protected string Braked;

		protected DateTime Start;
        protected DateTime End;
        CarInfo Car;
        Trailer TrailerInfo;
        Booking BookingInfo;
        PickUp PickUp;


        /// <summary>
        /// Metod som är start skärmen.
        /// Alla andra metoder anropas här i den ordningen gränssnittet ska vara
        /// </summary>

		public void StartPage() {
            Console.WriteLine("Welcome to Orel's Rental Cars");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Press any key to continue");
			Console.ReadKey();
			Console.Clear();
            BookingInfo = BookingDetails();
            PickUp = PickUpInfo();
            MainPageBodyType();
            Car = new CarInfo(CarModel, HorsePower, TowCapacity, Doors, InputBodyType, InputFuelInfo, InputTransmission, VehicleType, Tyres);
			TrailerInfo = MainPageTrailer();
            PossibleCars();
            
		}

        /// <summary>
        /// Metod som ber användaren att skriva information om sig själv
        /// </summary>
        /// <returns>returnerar användarens input</returns>

        public Booking BookingDetails() {
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

            Console.Clear();

            Booking BookingInfo = new Booking(inputName, age, inputEmail, inputPhoneNumber, inputAdress);
            return BookingInfo;
		}

        /// <summary>
        /// Metoden ber användaren att skriva när och vart man ska hämta bilen samt vart man ska lämna den
        /// </summary>
        /// <returns>returnar användarens input</returns>

        public PickUp PickUpInfo() {
            Console.WriteLine("When would you like to pick up your car? DD/MM");
            string startTimeInput = Console.ReadLine();
            Console.WriteLine("When would you like to leave your car? DD/MM");
            string endTimeInput = Console.ReadLine();

            Start = DateTime.ParseExact(startTimeInput, "d MMMM", CultureInfo.InvariantCulture);
			End = DateTime.ParseExact(endTimeInput, "d MMMM", CultureInfo.InvariantCulture);

            Console.WriteLine("Where would you like to pick the car up. Choose between Stockholm, Malmö and Gothenburg");

            string LocationInput = Console.ReadLine();

            PickUp PickUpInfo = new PickUp(Start, End, LocationInput);

            return PickUpInfo;

        }

		/// <summary>
		/// Metod som ber användaren att skriva vilken karosstyp man vill ha
		/// </summary>
		/// <returns>användarens input</returns>


		public CarInfo MainPageBodyType() {
            Console.Clear();
            Console.WriteLine("Which of the following car bodytypes would you like?");
            Console.WriteLine("1. Sedan");
            Console.WriteLine("2. Suv");
            Console.WriteLine("3. Kombi");
            Console.WriteLine("4. Sport");
            InputBodyType = Console.ReadLine();
            int numChoice;

            while(!int.TryParse(InputBodyType, out numChoice)) {
                Console.WriteLine("Please write a number");
                InputBodyType = Console.ReadLine();
            }

            if (numChoice == 1) {
                InputBodyType = "Sedan";
                MainPageFuelType();
            } else if (numChoice == 2) {
                InputBodyType = "Suv";
                MainPageFuelType();
            } else if (numChoice == 3) {
                InputBodyType = "Kombi";
                MainPageFuelType();
            } else if (numChoice == 4) {
                InputBodyType = "Sport";
                MainPageFuelType();
            }

            CarInfo carInfo = new CarInfo(CarModel, HorsePower, TowCapacity, Doors, InputBodyType, InputFuelInfo, InputTransmission, VehicleType, Tyres);
            return carInfo;
        }

		/// <summary>
		/// Metod som ber användaren att skriva vilket bränsle man vill ha
		/// </summary>
		/// <returns>användarens input</returns>

		public CarInfo MainPageFuelType() {
			Console.Clear();
			Console.WriteLine("Which fueltype would you like on your car?");
			Console.WriteLine("1. Petrol");
			Console.WriteLine("2. Diesel");
			Console.WriteLine("3. Electric");
            InputFuelInfo = Console.ReadLine();
            int numChoice;

			while (!int.TryParse(InputFuelInfo, out numChoice)) {
				Console.WriteLine("Please write a number");
				InputFuelInfo = Console.ReadLine();
			}
			if (numChoice == 1) {
                InputFuelInfo = "Petrol";
                MainPageTransmission();
            } else if (numChoice == 2) {
                InputFuelInfo = "Diesel";
                MainPageTransmission();
            } else if (numChoice == 3) {
                InputFuelInfo = "Electric";
                
            }

			CarInfo carInfo = new CarInfo(CarModel, HorsePower, TowCapacity, Doors, InputBodyType, InputFuelInfo, InputTransmission, VehicleType, Tyres);
			return carInfo;
		}

		/// <summary>
		/// Metod som ber användaren att skriva vilken växeltyp man vill
		/// </summary>
		/// <returns>användarens input</returns>

		public CarInfo MainPageTransmission() {
            Console.Clear();
            Console.WriteLine("Which transmission would you like ?");
            Console.WriteLine("1. Manual");
            Console.WriteLine("2. Automatic");
            InputTransmission = Console.ReadLine();
            int numChoice;
			while (!int.TryParse(InputTransmission, out numChoice)) {
				Console.WriteLine("Please write a number");
				InputTransmission = Console.ReadLine();
			}
			if  (numChoice == 1) {
                InputTransmission = "Manual";
                
            } else if (numChoice == 2) {
                InputTransmission = "Automatic";
                
            }

			CarInfo carInfo = new CarInfo(CarModel, HorsePower, TowCapacity, Doors, InputBodyType, InputFuelInfo, InputTransmission, VehicleType, Tyres);
			return carInfo;
		}

		/// <summary>
		/// Metod som ber användaren att skriva om man vill ha ett släp
		/// </summary>
		/// <returns>null</returns>

		public Trailer MainPageTrailer() {
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
				string InputTrailerType = Console.ReadLine();
				int numChoiceTrailer;
				while (!int.TryParse(InputTrailerType, out numChoiceTrailer)) {
					Console.WriteLine("Please write a number");
					InputTrailerType = Console.ReadLine();
				} 

               if (numChoiceTrailer == 1) {
                    return Trailer.trailerList[0];
					

			   } else if (numChoiceTrailer == 2) {
					return Trailer.trailerList[1];

				}


			} else if (numChoice == 2) {
                
            }
            return null;
		}

		/// <summary>
		/// Metod som skriver ut den bilen man har valt
		/// </summary>

		public void PossibleCars() {
            Console.WriteLine("Your chosen car: ");

            List<CarInfo> PossibleCarChoices = CarInfo.MethodOfElimination(InputBodyType, InputTransmission, InputFuelInfo);
            for(int i = 0; i < PossibleCarChoices.Count; i++) {
                Console.WriteLine(PossibleCarChoices[i].CarModel);
                
            }

            if (PossibleCarChoices.Count == 0) {
                Console.WriteLine("No cars matched your preferences.");
                Environment.Exit(1);
            } else {
                Car = PossibleCarChoices[0];
            }

            Console.Clear();
            LastInfo();    

            Console.ReadLine();
            
		}

        /// <summary>
        /// Metod som sammanfattar hyrningen.
        /// </summary>

        public void LastInfo() {
            LastInfo lastInfo = new LastInfo();
            lastInfo.Summary(BookingInfo, PickUp, Car, TrailerInfo);
			Console.WriteLine("-----------------");
			Console.WriteLine("The price will be: " + lastInfo.PriceBasedOnCar(InputBodyType, 1000, Start, End) + "kr");

        }





    }
}
