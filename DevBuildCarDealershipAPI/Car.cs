using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBuildCarDealershipAPI
{
    public class Car
    {
        public int CarID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car(int carID, string make, string model, int year, string color)
        {
            CarID = carID;
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }
    }
}
