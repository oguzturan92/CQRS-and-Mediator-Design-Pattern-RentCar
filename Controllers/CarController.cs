using CQRS_Mediator_Car.CQRSPattern.Commands.Car;
using CQRS_Mediator_Car.CQRSPattern.Handlers.Car;
using CQRS_Mediator_Car.CQRSPattern.Queries.Car;
using CQRS_Mediator_Car.MediatorPattern.Handlers;
using CQRS_Mediator_Car.MediatorPattern.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Mediator_Car.Controllers
{
    public class CarController : Controller
    {
        // CAR INJECTIONLARI
        private readonly GetCarQueryHandler _getCarQueryHandler;
        private readonly CreateCarCommandHandler _createCarCommandHandler;
        private readonly RemoveCarCommandHandler _removeCarCommandHandler;
        private readonly UpdateCarCommandHandler _updateCarCommandHandler;
        private readonly GetCarByIdQueryHandler _getCarByIdQueryHandler;

        // BRAND INJECTIONLARI
        private readonly IMediator _mediator;
        public CarController(GetCarQueryHandler getCarQueryHandler, CreateCarCommandHandler createCarCommandHandler, RemoveCarCommandHandler removeCarCommandHandler, UpdateCarCommandHandler updateCarCommandHandler, GetCarByIdQueryHandler getCarByIdQueryHandler, IMediator mediator)
        {
            _getCarQueryHandler = getCarQueryHandler;
            _createCarCommandHandler = createCarCommandHandler;
            _removeCarCommandHandler = removeCarCommandHandler;
            _updateCarCommandHandler = updateCarCommandHandler;
            _getCarByIdQueryHandler = getCarByIdQueryHandler;

            _mediator = mediator;
        }
        

        public IActionResult CarList()
        {
            var values = _getCarQueryHandler.Handle();
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> CarCreateAsync()
        {
            ViewBag.brands = await _mediator.Send(new GetBrandQuery());
            return View();
        }

        [HttpPost]
        public IActionResult CarCreate(CreateCarCommand command)
        {
            _createCarCommandHandler.Handle(command);
            return RedirectToAction("CarList", "Car");
        }

        [HttpGet]
        public async Task<IActionResult> CarUpdateAsync(int id)
        {
            ViewBag.brands = await _mediator.Send(new GetBrandQuery());
            var value = _getCarByIdQueryHandler.Handle(new GetCarByIdQuery(id));
            return View(value);
        }

        [HttpPost]
        public IActionResult CarUpdate(UpdateCarCommand updateCarCommand)
        {   
            _updateCarCommandHandler.Handle(updateCarCommand);
            return RedirectToAction("CarList", "Car");
        }

        public IActionResult CarRemove(int id)
        {
            _removeCarCommandHandler.Handle(new RemoveCarCommand(id));
            return RedirectToAction("CarList", "Car");
        }
    }
}