using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_Mediator_Car.CQRSPattern.Results.Feature
{
    public class GetFeatureByCarIdQueryResult
    {
        public int FeatureId { get; set; }
        public string FeatureName { get; set; }
        public int CarId { get; set; }
        public DAL.Car Car { get; set; }
    }
}