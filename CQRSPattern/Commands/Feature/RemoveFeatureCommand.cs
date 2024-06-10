using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_Mediator_Car.CQRSPattern.Commands.Feature
{
    public class RemoveFeatureCommand
    {
        public int FeatureId { get; set; }
        public RemoveFeatureCommand(int featureId)
        {
            FeatureId = featureId;
        }
    }
}