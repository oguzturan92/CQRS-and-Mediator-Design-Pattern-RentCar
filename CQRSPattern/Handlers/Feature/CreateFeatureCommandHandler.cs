using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS_Mediator_Car.CQRSPattern.Commands.Feature;
using CQRS_Mediator_Car.DAL;

namespace CQRS_Mediator_Car.CQRSPattern.Handlers.Feature
{
    public class CreateFeatureCommandHandler
    {
        private readonly Context _context;
        public CreateFeatureCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(CreateFeatureCommand command)
        {
            var value = new DAL.Feature{
                FeatureName = command.FeatureName,
                CarId = command.CarId
            };
            _context.Features.Add(value);
            _context.SaveChanges();
        }
    }
}