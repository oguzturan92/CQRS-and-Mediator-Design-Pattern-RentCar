using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS_Mediator_Car.DAL;
using CQRS_Mediator_Car.MediatorPattern.Commands;
using MediatR;

namespace CQRS_Mediator_Car.MediatorPattern.Handlers
{
    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand>
    {
        private readonly Context _context;
        public CreateBrandCommandHandler(Context context)
        {
            _context = context;
        }
        public async Task Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            var value = new Brand()
            {
                BrandName = request.BrandName
            };
            await _context.Brands.AddAsync(value);
            await _context.SaveChangesAsync();
        }
    }
}