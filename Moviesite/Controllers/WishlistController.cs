namespace Moviesite.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    public class WishlistController : Controller
    {
        private readonly ILogger<WishlistController> _logger;

        public WishlistController(ILogger<WishlistController> logger)
        {
            this._logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
