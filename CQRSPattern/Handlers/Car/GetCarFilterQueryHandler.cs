using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS_Mediator_Car.CQRSPattern.Queries.Car;
using CQRS_Mediator_Car.CQRSPattern.Results.Car;
using CQRS_Mediator_Car.DAL;

namespace CQRS_Mediator_Car.CQRSPattern.Handlers.Car
{
    public class GetCarFilterQueryHandler
    {
        private readonly Context _context;
        public GetCarFilterQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetCarFilterQueryResult> Handle(GetCarFilterQuery getCarFilterQuery)
        {
            // SORGULAMA KRİTERLERİ
            // 1- BULUNDUĞU İL
            // 2- TALEP EDİLEN ALIM VE TESLİM TARİHİ, ARACIN MEVCUT KİRALAMA BAŞLANGIÇ SÜRECİNDEN ÖNCE İSE VEYA MEVCUT KİRALAMA SÜRECİNİN BİTİŞİNDEN SONRA İSE
            var values = _context.Cars
            .Where(i => i.CarInProvince == getCarFilterQuery.StartCity && ((getCarFilterQuery.StartDate < i.CarRentStartDate && getCarFilterQuery.FinishDate < i.CarRentStartDate) || (getCarFilterQuery.StartDate > i.CarRentFinishDate && getCarFilterQuery.FinishDate > i.CarRentFinishDate)))
            .Select(i => new GetCarFilterQueryResult
            {
                CarId = i.CarId,
                CarName = i.CarName,
                CarImage = i.CarImage,
                CarFuelType = i.CarFuelType,
                CarLuggage = i.CarLuggage,
                CarDoor = i.CarDoor,
                CarPessenger = i.CarPessenger,
                CarDayPrice = i.CarDayPrice,
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