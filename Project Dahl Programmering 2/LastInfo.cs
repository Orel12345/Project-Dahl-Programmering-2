using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dahl_Programmering_2 {
	internal class LastInfo {

		
		PickUp PickUpSum;
		CarInfo CarSum;
		Trailer TrailerSum;

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

		public void Summary(Booking bookingInfo) {
			
			Console.WriteLine("A summary of your booking details");
			Console.WriteLine("Your Name: " + bookingInfo.Name);
			Console.WriteLine("age: " + bookingInfo.Age);
            Console.WriteLine("Email: " + bookingInfo.Email);
            Console.WriteLine("Phone Number: " + bookingInfo.PhoneNumber);
            Console.WriteLine("Adress: " + bookingInfo.Adress);

            Console.WriteLine("A summary of your pick up information");
            Console.WriteLine("Booking duration: " + PickUpSum.Start + " to " + PickUpSum.End);
            Console.WriteLine("Pick up location: " + PickUpSum.PickUpLocation);

            Console.WriteLine("A summary of the car booking");
            Console.WriteLine("Vehicle type: " + CarSum.VehicleType);
            Console.WriteLine("Car model: " + CarSum.CarModel);
            Console.WriteLine("Car body type: " + CarSum.BodyType);
            Console.WriteLine("Fuel info: " + CarSum.FuelInfo);
            Console.WriteLine("Tranmission: " + CarSum.Transmission);
			Console.WriteLine("Horse Power:	" + CarSum.HorsePower);
            Console.WriteLine("Tow Capacity: " + CarSum.TowCapacity);
            Console.WriteLine("Doors: " + CarSum.Doors);
            Console.WriteLine("Tyres: " + CarSum.Tyres);

            Console.WriteLine("A summary of chosen Trailer (if chosen)");
            Console.WriteLine("Vehicle type: " + TrailerSum.VehicleType);
            Console.WriteLine("Tyres: " + TrailerSum.Tyres);
            Console.WriteLine("Trailer type: " + TrailerSum.TrailerType);
            Console.WriteLine("Max weight: " + TrailerSum.MaxWeight);
            Console.WriteLine("Volume: " + TrailerSum.Volume);
            Console.WriteLine("Braked info: " + TrailerSum.Braked);
            Console.WriteLine("Fuel info: " + TrailerSum.FuelInfo);

            


        }


	}
}
