using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_Mediator_Car.CQRSPattern.Commands.Car
{
    public class UpdateCarCommand
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string CarImage { get; set; }
        public string CarFuelType { get; set; }
        public int CarLuggage { get; set; }
        public int CarDoor { get; set; }
        public int CarPessenger { get; set; }
        public float CarDayPrice { get; set; }
        public string CarDescription { get; set; }
        public string FeatureAutomaticTransmission { get; set; }
        public string CarInProvince { get; set; }
        public DateTime CarRentStartDate { get; set; }
        public DateTime CarRentFinishDate { get; set; }
        public int BrandId { get; set; }
    }
}