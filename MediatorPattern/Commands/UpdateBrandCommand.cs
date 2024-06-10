using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CQRS_Mediator_Car.MediatorPattern.Commands
{
    public class UpdateBrandCommand : IRequest
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}