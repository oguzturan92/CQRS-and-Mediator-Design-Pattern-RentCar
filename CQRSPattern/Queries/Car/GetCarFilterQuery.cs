using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_Mediator_Car.CQRSPattern.Queries.Car
{
    public class GetCarFilterQuery
    {
        public string StartCity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public GetCarFilterQuery(string startCity, DateTime startDate, DateTime finishDate)
        {
            StartCity = startCity;
            StartDate = startDate;
            FinishDate = finishDate;
        }
    }
}