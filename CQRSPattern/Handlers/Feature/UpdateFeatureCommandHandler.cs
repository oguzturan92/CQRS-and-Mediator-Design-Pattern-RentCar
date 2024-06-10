using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS_Mediator_Car.CQRSPattern.Commands.Feature;
using CQRS_Mediator_Car.DAL;

namespace CQRS_Mediator_Car.CQRSPattern.Handlers.Feature
{
    public class UpdateFeatureCommandHandler
    {
        private readonly Context _context;
        public UpdateFeatureCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateFeatureCommand command)
        {
            var value = _context.Features.Find(command.FeatureId);
            if (value != null)
            {
                value.FeatureId = command.FeatureId;
                value.FeatureName = command.FeatureName;
                value.CarId = command.CarId;
                _context.SaveChanges();
            }
        }
    }
}