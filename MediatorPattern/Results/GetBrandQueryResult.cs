using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_Mediator_Car.MediatorPattern.Results
{
    public class GetBrandQueryResult
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}