using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS_Mediator_Car.CQRSPattern.Results.Car;
using CQRS_Mediator_Car.DAL;

namespace CQRS_Mediator_Car.CQRSPattern.Handlers.Car
{
    public class GetCarQueryHandler
    {
        private readonly Context _context;
        public GetCarQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetCarQueryResult> Handle()
        {
            var values = _context.Cars.Select(i => new GetCarQueryResult
            {
                CarId = i.CarId,
                CarName = i.CarName,
                CarImage = i.CarImage,
                CarDescription = i.CarDescription,
                FeatureAutomaticTransmission = i.FeatureAutomaticTransmission,
                CarInProvince = i.CarInProvince,
                CarRentStartDate = i.CarRentStartDate,
                CarRentFinishDate = i.CarRentFinishDate,
                Brand = i.Brand,
                Features = i.Features
            }).ToList();
            return values;
        }
    }
}