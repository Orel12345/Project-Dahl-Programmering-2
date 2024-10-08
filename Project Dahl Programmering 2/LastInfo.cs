using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Dahl_Programmering_2 {
	internal class LastInfo {
        public double PriceBasedOnCar(string BodyType, double price, DateTime start, DateTime end) {
			if (BodyType == "Sedan" || BodyType == "Suv" || BodyType == "Kombi") {
				price = 1000;
				TimeSpan days = end - start;
				days.Days;
			} else if (BodyType == "Sport") {
				price = price * 5;

			}

			return price;
			
		}


	}
}
