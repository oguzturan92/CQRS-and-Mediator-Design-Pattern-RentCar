using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_Mediator_Car.CQRSPattern.Queries.Feature
{
    public class GetFeatureByCarIdQuery
    {
        public int Id { get; set; }
        public GetFeatureByCarIdQuery(int carId)
        {
            Id = carId;
        }
    }
}