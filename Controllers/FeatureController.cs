using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS_Mediator_Car.CQRSPattern.Commands.Feature;
using CQRS_Mediator_Car.CQRSPattern.Handlers.Feature;
using CQRS_Mediator_Car.CQRSPattern.Queries.Feature;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Mediator_Car.Controllers
{
    public class FeatureController : Controller
    {
        // FEATURE INJECTIONLARI
        private readonly GetFeatureByCarIdQueryHandler _getFeatureByCarIdQueryHandler;
        private readonly GetFeatureByIdQueryHandler _getFeatureByIdQueryHandler;
        private readonly CreateFeatureCommandHandler _createFeatureCommandHandler;
        private readonly RemoveFeatureCommandHandler _removeFeatureCommandHandler;
        private readonly UpdateFeatureCommandHandler _updateFeatureCommandHandler;
        public FeatureController(GetFeatureByCarIdQueryHandler getFeatureByCarIdQueryHandler, GetFeatureByIdQueryHandler getFeatureByIdQueryHandler, CreateFeatureCommandHandler createFeatureCommandHandler, RemoveFeatureCommandHandler removeFeatureCommandHandler, UpdateFeatureCommandHandler updateFeatureCommandHandler)
        {
            _getFeatureByCarIdQueryHandler = getFeatureByCarIdQueryHandler;
            _getFeatureByIdQueryHandler = getFeatureByIdQueryHandler;
            _createFeatureCommandHandler = createFeatureCommandHandler;
            _removeFeatureCommandHandler = removeFeatureCommandHandler;
            _updateFeatureCommandHandler = updateFeatureCommandHandler;
        }
        public IActionResult FeatureList(int carId)
        {
            // CarId bilgisine göre Feature'lar, yani Bağlı olduğu Car'a göre Feature'lar
            var values = _getFeatureByCarIdQueryHandler.Handle(new GetFeatureByCarIdQuery(carId));
            ViewBag.carId = carId;
            return View(values);
        }

        [HttpGet]
        public IActionResult FeatureCreate(int carId)
        {
            ViewBag.carId = carId;
            return View();
        }

        [HttpPost]
        public IActionResult FeatureCreate(CreateFeatureCommand createFeatureCommand)
        {
            _createFeatureCommandHandler.Handle(createFeatureCommand);
            return RedirectToAction("FeatureList", "Feature", new { carId = createFeatureCommand.CarId});
        }

        [HttpGet]
        public IActionResult FeatureUpdate(int id)
        {
            var value = _getFeatureByIdQueryHandler.Handle(new GetFeatureByIdQuery(id));
            return View(value);
        }

        [HttpPost]
        public IActionResult FeatureUpdate(UpdateFeatureCommand updateFeatureCommand)
        {
            _updateFeatureCommandHandler.Handle(updateFeatureCommand);
            return RedirectToAction("FeatureList", "Feature", new { carId = updateFeatureCommand.CarId});
        }

        public IActionResult FeatureRemove(int id, int carId)
        {
            _removeFeatureCommandHandler.Handle(new RemoveFeatureCommand(id));
            return RedirectToAction("FeatureList", "Feature", new { carId = carId});
        }
    }
}