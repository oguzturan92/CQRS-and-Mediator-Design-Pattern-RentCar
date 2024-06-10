using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_Mediator_Car.CQRSPattern.Results.Feature
{
    public class GetFeatureByIdQueryResult
    {
        public int FeatureId { get; set; }
        public string FeatureName { get; set; }
        public int CarId { get; set; }
    }
}