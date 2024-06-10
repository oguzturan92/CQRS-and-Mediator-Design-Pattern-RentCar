using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS_Mediator_Car.MediatorPattern.Results;
using MediatR;

namespace CQRS_Mediator_Car.MediatorPattern.Queries
{
    public class GetBrandByIdQuery : IRequest<GetBrandByIdQueryResult>
    {
        public int Id { get; set; }
        public GetBrandByIdQuery(int id)
        {
            Id = id;
        }
    }
}