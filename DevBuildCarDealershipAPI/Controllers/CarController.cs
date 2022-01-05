using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevBuildCarDealershipAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : Controller
    {
        List<Car> Cars = new List<Car>()
        {
            new Car(1, "Toyota", "Equinox", 2021, "blue"),
            new Car(2, "Chrystler", "Town and Country", 2021, "white"),
            new Car(3, "Ford", "F-150", 2021, "orange"),
            new Car(4, "Hyundai", "Zoomies", 2021, "orange"),
            new Car(5, "Rocket", "Ship", 2021, "black"),
            new Car(6, "Rocket", "Ship", 2022, "black"),
            new Car(7, "Toyota", "F-150", 2022, "black"),
            new Car(8, "Ford", "Ship", 2022, "black")
        };

        [HttpGet]
        public IEnumerable<Car> GetCars()
        {
            return Cars;
        }

        [HttpGet("carID/{carID}")]
        public IEnumerable<Car> GetCarsById(int carID)
        {
            return Cars.Where(c => c.CarID == carID);
        }

        [HttpGet("Make/{make}")]
        public IEnumerable<Car> GetCarsByMake(string make)
        {
            return Cars.Where(c => c.Make == make);
        }

        [HttpGet("Model/{model}")]
        public IEnumerable<Car> GetCarsByModel(string model)
        {
            return Cars.Where(c => c.Model == model);
        }

        [HttpGet("Year/{year}")]
        public IEnumerable<Car> GetCarsByYear(int year)
        {
            return Cars.Where(c => c.Year == year);
        }

        [HttpGet("Color/{color}")]
        public IEnumerable<Car> GetCarsByColor(string color)
        {
            return Cars.Where(c => c.Color == color);
        }

        //[HttpGet("Search/{stMake?}/{stModel?}")]
        [HttpGet("Search/")]
        //To call this the format will be car/Search?[variableName]=[value]&....
        public IEnumerable<Car> SearchCars(int? stCarID = null,
            string stMake = null,
            string stModel = null,
            int? stYear = null,
            string stColor = null)
        {
            return Cars.Where(c => c.CarID == stCarID ||
            c.Make == stMake ||
            c.Model == stModel ||
            c.Year == stYear ||
            c.Color == stColor);
        }

        
        [HttpGet("NewCar/")]
        //To call this the format will be car/newcar?[variableName]=[value]&....
        public Object NewCar(int stCarID = 0,
            string stMake = null,
            string stModel = null,
            int stYear = 0000,
            string stColor = null)
        {
            Cars.Add(new Car(stCarID, stMake, stModel, stYear, stColor));

            return new
            {
                status = "sucess",
                carId = Cars.Last().CarID
            };
        }


    }
}
