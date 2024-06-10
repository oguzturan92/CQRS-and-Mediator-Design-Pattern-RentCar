using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS_Mediator_Car.MediatorPattern.Results;
using MediatR;

namespace CQRS_Mediator_Car.MediatorPattern.Queries
{
    public class GetBrandQuery : IRequest<List<GetBrandQueryResult>>
    {
        
    }
}