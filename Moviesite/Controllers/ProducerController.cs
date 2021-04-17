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
