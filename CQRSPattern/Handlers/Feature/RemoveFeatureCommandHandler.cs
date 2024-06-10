using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS_Mediator_Car.CQRSPattern.Commands.Feature;
using CQRS_Mediator_Car.DAL;

namespace CQRS_Mediator_Car.CQRSPattern.Handlers.Feature
{
    public class RemoveFeatureCommandHandler
    {
        private readonly Context _context;
        public RemoveFeatureCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(RemoveFeatureCommand command)
        {
            var value = _context.Features.Find(command.FeatureId);
            if (value != null)
            {
                _context.Remove(value);
                _context.SaveChanges();
            }
        }
    }
}