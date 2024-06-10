using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS_Mediator_Car.CQRSPattern.Queries.Feature;
using CQRS_Mediator_Car.CQRSPattern.Results.Feature;
using CQRS_Mediator_Car.DAL;

namespace CQRS_Mediator_Car.CQRSPattern.Handlers.Feature
{
    public class GetFeatureByCarIdQueryHandler
    {
        private readonly Context _context;
        public GetFeatureByCarIdQueryHandler(Context context)
        {
            _context = context;
        }

        public List<GetFeatureByCarIdQueryResult> Handle(GetFeatureByCarIdQuery getFeatureByCarIdQuery)
        {
            var values = _context.Features.Where(i => i.CarId == getFeatureByCarIdQuery.Id).Select(i => new GetFeatureByCarIdQueryResult
            {
                CarId = i.CarId,
                FeatureId = i.FeatureId,
                FeatureName = i.FeatureName
            }).ToList();
            return values;
        }
    }
}