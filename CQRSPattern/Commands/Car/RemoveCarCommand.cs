using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_Mediator_Car.CQRSPattern.Commands.Car
{
    public class RemoveCarCommand
    {
        public int CarId { get; set; }
        public RemoveCarCommand(int carId)
        {
            CarId = carId;
        }
    }
}