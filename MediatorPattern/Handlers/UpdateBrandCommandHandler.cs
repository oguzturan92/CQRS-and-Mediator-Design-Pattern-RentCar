using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS_Mediator_Car.DAL;
using CQRS_Mediator_Car.MediatorPattern.Commands;
using MediatR;

namespace CQRS_Mediator_Car.MediatorPattern.Handlers
{
    public class UpdateBrandCommandHandler : IRequestHandler<UpdateBrandCommand>
    {
        private readonly Context _context;
        public UpdateBrandCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(UpdateBrandCommand request, CancellationToken cancellationToken)
        {
            var values = await _context.Brands.FindAsync(request.BrandId);
            values.BrandName = request.BrandName;
            await _context.SaveChangesAsync();
        }
    }
}