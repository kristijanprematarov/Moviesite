namespace Moviesite.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Moviesite.Entities;
    using Moviesite.Service.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class ActorController : Controller
    {
        private readonly IActorService _actorService;

        public ActorController(IActorService actorService)
        {
            _actorService = actorService;
        }

        public IActionResult Index()
        {
            var actorsList = _actorService.GetAllActors();
            return View(actorsList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Actor actor)
        {
            if (ModelState.IsValid)
            {
                _actorService.Add(actor);
            }

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var actor = _actorService.GetActorById(id);
            return View(actor);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var actor = _actorService.GetActorById(id);
            return View(actor);
        }

        [HttpPost]
        public IActionResult Edit(Actor actor)
        {
            _actorService.Edit(actor);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var actor = _actorService.GetActorById(id);
            return View(actor);
        }

        [HttpPost]
        public IActionResult Delete(Actor actor)
        {
            _actorService.Delete(actor.Id);

            return RedirectToAction(nameof(Index));
        }
    }
}
