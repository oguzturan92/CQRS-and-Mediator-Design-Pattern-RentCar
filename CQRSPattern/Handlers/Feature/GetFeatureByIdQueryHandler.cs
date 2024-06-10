using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS_Mediator_Car.CQRSPattern.Queries.Feature;
using CQRS_Mediator_Car.CQRSPattern.Results.Feature;
using CQRS_Mediator_Car.DAL;

namespace CQRS_Mediator_Car.CQRSPattern.Handlers.Feature
{
    public class GetFeatureByIdQueryHandler
    {
        private readonly Context _context;
        public GetFeatureByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetFeatureByIdQueryResult Handle(GetFeatureByIdQuery getFeatureByIdQuery)
        {
            var value = _context.Features.Find(getFeatureByIdQuery.Id);
            var newValue = new GetFeatureByIdQueryResult
            {
                FeatureId = value.FeatureId,
                FeatureName = value.FeatureName,
                CarId = value.CarId
            };
            return newValue;
        }
    }
}