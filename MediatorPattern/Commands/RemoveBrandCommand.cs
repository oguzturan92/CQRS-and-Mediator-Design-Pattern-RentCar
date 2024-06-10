using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace CQRS_Mediator_Car.MediatorPattern.Commands
{
    public class RemoveBrandCommand : IRequest
    {
        public int BrandId { get; set; }
        public RemoveBrandCommand(int brandId)
        {
            BrandId = brandId;
        }
    }
}