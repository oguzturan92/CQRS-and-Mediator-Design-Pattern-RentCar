using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS_Mediator_Car.CQRSPattern.Commands.Car;
using CQRS_Mediator_Car.DAL;

namespace CQRS_Mediator_Car.CQRSPattern.Handlers.Car
{
    public class RemoveCarCommandHandler
    {
        private readonly Context _context;
        public RemoveCarCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(RemoveCarCommand command)
        {
            var value = _context.Cars.Find(command.CarId);
            if (value != null)
            {
                _context.Remove(value);
                _context.SaveChanges();
            }
        }
    }
}