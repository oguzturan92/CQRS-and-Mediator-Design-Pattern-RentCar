using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS_Mediator_Car.CQRSPattern.Commands.Car;
using CQRS_Mediator_Car.DAL;

namespace CQRS_Mediator_Car.CQRSPattern.Handlers.Car
{
    public class CreateCarCommandHandler
    {
        private readonly Context _context;
        public CreateCarCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateCarCommand command)
        {
            var value = new DAL.Car{
                CarName = command.CarName,
                CarImage = command.CarImage,
                CarFuelType = command.CarFuelType,
                CarLuggage = command.CarLuggage,
                CarDoor = command.CarDoor,
                CarPessenger = command.CarPessenger,
                CarDayPrice = command.CarDayPrice,
                CarDescription = command.CarDescription,
                FeatureAutomaticTransmission = command.FeatureAutomaticTransmission,
                CarInProvince = command.CarInProvince,
                CarRentStartDate = command.CarRentStartDate,
                CarRentFinishDate = command.CarRentFinishDate,
                BrandId = command.BrandId
            };
            _context.Cars.Add(value);
            _context.SaveChanges();
        }
    }
}