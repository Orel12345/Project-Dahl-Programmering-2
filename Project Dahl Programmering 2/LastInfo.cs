using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dahl_Programmering_2 {
	internal class LastInfo {

		/// <summary>
		/// Räknar ut priset för hyrbilen beroende hur länge och vilken karosstyp det är
		/// </summary>
		/// <param name="BodyType">tar info om karosstyp</param>
		/// <param name="price">start priset</param>
		/// <param name="start">start datum</param>
		/// <param name="end">slut datum</param>
		/// <returns></returns>

		public double PriceBasedOnCar(string BodyType, double price, DateTime start, DateTime end) {
			if (BodyType == "Sedan" || BodyType == "Suv" || BodyType == "Kombi") {
				TimeSpan days = end - start;
				price += 100 * days.Days;
			} else if (BodyType == "Sport") {
				price = price * 5;
				TimeSpan days = end - start;
				price += 100 * days.Days;

			}

			return price;
			
		}

		/// <summary>
		/// Metoden skriver ut sammanfattningen av det man har hyrt
		/// </summary>
		/// <param name="BookingInfo">Användarens input om boknings detaljerna</param>
		/// <param name="PickUpInfo">Användarens input om upphämntings detaljer</param>
		/// <param name="carInfo">Användarens input om bilen</param>
		/// <param name="trailerChoice">Användarens input om släpet</param>

		public void Summary(Booking BookingInfo, PickUp PickUpInfo,CarInfo carInfo, Trailer trailerChoice) {
			
			Console.WriteLine("A summary of your booking details");
			Console.WriteLine("Your Name: " + BookingInfo.Name);
			Console.WriteLine("age: " + BookingInfo.Age);
            Console.WriteLine("Email: " + BookingInfo.Email);
            Console.WriteLine("Phone Number: " + BookingInfo.PhoneNumber);
            Console.WriteLine("Adress: " + BookingInfo.Adress);

            Console.WriteLine("-----------------");

            Console.WriteLine("A summary of your pick up information");
            Console.WriteLine("Booking duration: " + PickUpInfo.Start + " to " + PickUpInfo.End);
            Console.WriteLine("Pick up location: " + PickUpInfo.PickUpLocation);

			Console.WriteLine("-----------------");

			Console.WriteLine("A summary of the car booking");
            Console.WriteLine("Vehicle type: " + carInfo.VehicleType);
            Console.WriteLine("Car model: " + carInfo.CarModel);
            Console.WriteLine("Car body type: " + carInfo.BodyType);
            Console.WriteLine("Fuel info: " + carInfo.FuelInfo);
            Console.WriteLine("Tranmission: " + carInfo.Transmission);
			Console.WriteLine("Horse Power:	" + carInfo.HorsePower);
            Console.WriteLine("Tow Capacity: " + carInfo.TowCapacity + "kg");
            Console.WriteLine("Doors: " + carInfo.Doors);
            Console.WriteLine("Tyres: " + carInfo.Tyres);

			Console.WriteLine("-----------------");

			if (trailerChoice != null) {
				Console.WriteLine("A summary of chosen Trailer");
				Console.WriteLine("Vehicle type: " + trailerChoice.VehicleType);
				Console.WriteLine("Tyres: " + trailerChoice.Tyres);
				Console.WriteLine("Trailer type: " + trailerChoice.TrailerType);
				Console.WriteLine("Max weight: " + trailerChoice.MaxWeight + "kg");
				Console.WriteLine("Volume: " + trailerChoice.Volume + "l");
				Console.WriteLine("Braked info: " + trailerChoice.Braked);
				Console.WriteLine("Fuel info: " + trailerChoice.FuelInfo);
			}

           

            


        }


	}
}
