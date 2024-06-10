using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS_Mediator_Car.DAL;
using CQRS_Mediator_Car.MediatorPattern.Commands;
using MediatR;

namespace CQRS_Mediator_Car.MediatorPattern.Handlers
{
    public class RemoveBrandCommandHandler : IRequestHandler<RemoveBrandCommand>
    {
        private readonly Context _context;
        public RemoveBrandCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(RemoveBrandCommand request, CancellationToken cancellationToken)
        {
            var value = _context.Brands.Find(request.BrandId);
            _context.Brands.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}