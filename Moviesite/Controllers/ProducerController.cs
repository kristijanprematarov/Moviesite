namespace Moviesite.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using Moviesite.Entities;
    using Moviesite.Service.Interfaces;

    public class ProducerController : Controller
    {
        private readonly IProducerService _producerService;
        private readonly ILogger<ProducerController> _logger;

        public ProducerController(IProducerService producerService, ILogger<ProducerController> logger)
        {
            _producerService = producerService;
            this._logger = logger;
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

        [HttpGet]
        public IActionResult Details(int id)
        {
            var producer = _producerService.GetProducerById(id);
            return View(producer);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var producer = _producerService.GetProducerById(id);
            return View(producer);
        }

        [HttpPost]
        public IActionResult Edit(Producer producer)
        {
            _producerService.Edit(producer);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var producer = _producerService.GetProducerById(id);
            return View(producer);
        }

        [HttpPost]
        public IActionResult Delete(Producer producer)
        {
            _producerService.Delete(producer.Id);

            return RedirectToAction(nameof(Index));
        }
    }
}
