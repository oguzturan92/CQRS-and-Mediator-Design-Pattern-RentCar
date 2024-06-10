using CQRS_Mediator_Car.CQRSPattern.Handlers.Car;
using CQRS_Mediator_Car.CQRSPattern.Queries.Car;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Mediator_Car.Controllers
{
    public class ListingController : Controller
    {
        private readonly GetCarFilterQueryHandler _getCarFilterQueryHandler;
        public ListingController(GetCarFilterQueryHandler getCarFilterQueryHandler)
        {
            _getCarFilterQueryHandler = getCarFilterQueryHandler;
        }

        public IActionResult Index(string startCity, string finishCity, DateTime startDate, DateTime finishDate, bool search)
        {
            ViewBag.search = false;
            if (search)
            {
                ViewBag.search = true;
            }
            var values = _getCarFilterQueryHandler.Handle(new GetCarFilterQuery(startCity, startDate, finishDate));
            return View(values);
        }
    }
}