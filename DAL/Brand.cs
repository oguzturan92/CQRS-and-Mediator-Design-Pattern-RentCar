using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_Mediator_Car.DAL
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public List<Car> Cars { get; set; }
    }
}