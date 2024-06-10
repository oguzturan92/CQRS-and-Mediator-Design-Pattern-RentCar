using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS_Mediator_Car.DAL;
using CQRS_Mediator_Car.MediatorPattern.Queries;
using CQRS_Mediator_Car.MediatorPattern.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRS_Mediator_Car.MediatorPattern.Handlers
{
    public class GetBrandQueryHandler : IRequestHandler<GetBrandQuery, List<GetBrandQueryResult>>
    {
        private readonly Context _context;

        public GetBrandQueryHandler(Context context)
        {
            _context = context;
        }
        
        public async Task<List<GetBrandQueryResult>> Handle(GetBrandQuery request, CancellationToken cancellationToken)
        {
            var values = _context.Brands.Select(i => new GetBrandQueryResult
            {
                BrandId = i.BrandId,
                BrandName = i.BrandName
            }).ToListAsync();
            return await values;
        }
    }
}