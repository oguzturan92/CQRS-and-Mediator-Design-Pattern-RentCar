using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS_Mediator_Car.CQRSPattern.Queries.Car;
using CQRS_Mediator_Car.CQRSPattern.Results.Car;
using CQRS_Mediator_Car.DAL;

namespace CQRS_Mediator_Car.CQRSPattern.Handlers.Car
{
    public class GetCarByIdQueryHandler
    {
        private readonly Context _context;
        public GetCarByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetCarByIdQueryResult Handle(GetCarByIdQuery getCarByIdQuery)
        {
            var value = _context.Cars.Find(getCarByIdQuery.Id);
            var newValue = new GetCarByIdQueryResult
            {
                CarId = value.CarId,
                CarName = value.CarName,
                CarImage = value.CarImage,
                CarFuelType = value.CarFuelType,
                CarLuggage = value.CarLuggage,
                CarDoor = value.CarDoor,
                CarPessenger = value.CarPessenger,
                CarDayPrice = value.CarDayPrice,
                CarDescription = value.CarDescription,
                FeatureAutomaticTransmission = value.FeatureAutomaticTransmission,
                CarInProvince = value.CarInProvince,
                CarRentStartDate = value.CarRentStartDate,
                CarRentFinishDate = value.CarRentFinishDate,
                BrandId = value.BrandId
            };
            return newValue;
        }
    }
}