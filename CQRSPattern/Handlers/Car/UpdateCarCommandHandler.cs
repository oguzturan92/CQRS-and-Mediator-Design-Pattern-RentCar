using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS_Mediator_Car.CQRSPattern.Commands.Car;
using CQRS_Mediator_Car.DAL;

namespace CQRS_Mediator_Car.CQRSPattern.Handlers.Car
{
    public class UpdateCarCommandHandler
    {
        private readonly Context _context;
        public UpdateCarCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateCarCommand command)
        {
            var value = _context.Cars.Find(command.CarId);
            if (value != null)
            {
                value.CarName = command.CarName;
                value.CarImage = command.CarImage;
                value.CarFuelType = command.CarFuelType;
                value.CarLuggage = command.CarLuggage;
                value.CarDoor = command.CarDoor;
                value.CarPessenger = command.CarPessenger;
                value.CarDayPrice = command.CarDayPrice;
                value.CarDescription = command.CarDescription;
                value.FeatureAutomaticTransmission = command.FeatureAutomaticTransmission;
                value.CarInProvince = command.CarInProvince;
                value.CarRentStartDate = command.CarRentStartDate;
                value.CarRentFinishDate = command.CarRentFinishDate;
                value.BrandId = command.BrandId;
                _context.SaveChanges();
            }
        }
    }
}