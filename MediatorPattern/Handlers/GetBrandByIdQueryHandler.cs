using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS_Mediator_Car.DAL;
using CQRS_Mediator_Car.MediatorPattern.Queries;
using CQRS_Mediator_Car.MediatorPattern.Results;
using MediatR;

namespace CQRS_Mediator_Car.MediatorPattern.Handlers
{
    public class GetBrandByIdQueryHandler : IRequestHandler<GetBrandByIdQuery, GetBrandByIdQueryResult>
    {
        private readonly Context _context;
        public GetBrandByIdQueryHandler(Context context)
        {
            _context = context;
        }
        public async Task<GetBrandByIdQueryResult> Handle(GetBrandByIdQuery request, CancellationToken cancellationToken)
        {

            var values = await _context.Brands.FindAsync(request.Id);
            return new GetBrandByIdQueryResult
            {
                BrandId = values.BrandId,
                BrandName = values.BrandName
            };
        }
    }
}