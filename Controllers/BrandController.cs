using CQRS_Mediator_Car.MediatorPattern.Commands;
using CQRS_Mediator_Car.MediatorPattern.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_Mediator_Brand.Controllers
{
    public class BrandController : Controller
    {
        // BRAND INJECTIONLARI
        private readonly IMediator _mediator;
        public BrandController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> BrandList()
        {
            var values = await _mediator.Send(new GetBrandQuery());
            return View(values);
        }

        [HttpGet]
        public IActionResult BrandCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> BrandCreate(CreateBrandCommand createBrandCommand)
        {
            await _mediator.Send(createBrandCommand);
            return RedirectToAction("BrandList", "Brand");
        }

        [HttpGet]
        public async Task<IActionResult> BrandUpdate(int id)
        {
            var value = await _mediator.Send(new GetBrandByIdQuery(id));
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> BrandUpdate(UpdateBrandCommand updateBrandCommand)
        {
            await _mediator.Send(updateBrandCommand);
            return RedirectToAction("BrandList", "Brand");
        }

        public async Task<IActionResult> BrandRemove(int id)
        {
            await _mediator.Send(new RemoveBrandCommand(id));
            return RedirectToAction("BrandList", "Brand");
        }
    }
}