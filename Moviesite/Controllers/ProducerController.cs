namespace Moviesite.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Moviesite.Entities;
    using Moviesite.Service.Interfaces;

    public class ProducerController : Controller
    {
        private readonly IProducerService _producerService;

        public ProducerController(IProducerService producerService)
        {
            _producerService = producerService;
        }

        public IActionResult Index()
        {
            var producersList = _producerService.GetAllProducers();
            return View(producersList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Producer producer)
        {
            if (ModelState.IsValid)
            {
                _producerService.Add(producer);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
