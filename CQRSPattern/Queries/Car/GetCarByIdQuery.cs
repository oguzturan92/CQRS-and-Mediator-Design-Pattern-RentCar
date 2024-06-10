using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_Mediator_Car.CQRSPattern.Queries.Car
{
    public class GetCarByIdQuery
    {
        public int Id { get; set; }
        public GetCarByIdQuery(int id)
        {
            Id = id;
        }
    }
}