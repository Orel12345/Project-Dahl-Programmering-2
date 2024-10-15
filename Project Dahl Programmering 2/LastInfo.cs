using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dahl_Programmering_2 {
	internal class LastInfo {


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

		public void Summary(Booking BookingInfo, PickUp PickUpInfo,CarInfo carInfo, Trailer trailerChoice) {
			
			Console.WriteLine("A summary of your booking details");
			Console.WriteLine("Your Name: " + BookingInfo.Name);
			Console.WriteLine("age: " + BookingInfo.Age);
            Console.WriteLine("Email: " + BookingInfo.Email);
            Console.WriteLine("Phone Number: " + BookingInfo.PhoneNumber);
            Console.WriteLine("Adress: " + BookingInfo.Adress);

            Console.WriteLine("A summary of your pick up information");
            Console.WriteLine("Booking duration: " + PickUpInfo.Start + " to " + PickUpInfo.End);
            Console.WriteLine("Pick up location: " + PickUpInfo.PickUpLocation);

            Console.WriteLine("A summary of the car booking");
            Console.WriteLine("Vehicle type: " + carInfo.VehicleType);
            Console.WriteLine("Car model: " + carInfo.CarModel);
            Console.WriteLine("Car body type: " + carInfo.BodyType);
            Console.WriteLine("Fuel info: " + carInfo.FuelInfo);
            Console.WriteLine("Tranmission: " + carInfo.Transmission);
			Console.WriteLine("Horse Power:	" + carInfo.HorsePower);
            Console.WriteLine("Tow Capacity: " + carInfo.TowCapacity);
            Console.WriteLine("Doors: " + carInfo.Doors);
            Console.WriteLine("Tyres: " + carInfo.Tyres);

            Console.WriteLine("A summary of chosen Trailer (if chosen)");
            Console.WriteLine("Vehicle type: " + trailerChoice.VehicleType);
            Console.WriteLine("Tyres: " + trailerChoice.Tyres);
            Console.WriteLine("Trailer type: " + trailerChoice.TrailerType);
            Console.WriteLine("Max weight: " + trailerChoice.MaxWeight);
            Console.WriteLine("Volume: " + trailerChoice.Volume);
            Console.WriteLine("Braked info: " + trailerChoice.Braked);
            Console.WriteLine("Fuel info: " + trailerChoice.FuelInfo);

            


        }


	}
}
