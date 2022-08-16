using Microsoft.AspNetCore.Mvc;
using TheDiscAppMVC.Models.Disc;
using TheDiscAppMVC.Services.Disc;

namespace TheDiscAppMVC.Controllers
{
    public class DiscController : Controller
    {
        private readonly IDiscService _discService;
        public DiscController(IDiscService discService)
        {
            _discService = discService;
        }

        public async Task<IActionResult> Index()
        {
            var discs = await _discService.GetAllDiscs();
            return View(discs);
        }

        public async Task<IActionResult> Details(int id)
        {
            var disc = await _discService.GetDiscById(id);

            if (disc == null)
            {
                return NotFound();
            }

            return View(disc);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DiscCreate model)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorMsg"] = "Model State is Invalid";
                return View(ModelState);
            }

            if (await _discService.CreateDisc(model))
            {
                return RedirectToAction(nameof(Index));
            }

            TempData["ErrorMsg"] = "Unable to save to the database. Please try again later.";

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            DiscDetail disc = await _discService.GetDiscById(id);

            if (disc == null)
            {
                return NotFound();
            }

            var customerEdit = new DiscEdit
            {
                Id = disc.Id,
                Name = disc.Name
            };

            return View(customerEdit);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, DiscEdit model)
        {
            if (id != model.Id || !ModelState.IsValid)
            {
                return View(ModelState);
            }

            bool wasUpdated = await _discService.UpdateDisc(model);

            if (wasUpdated)
            {
                return RedirectToAction("Details", new { id = model.Id });
            }

            ViewData["ErrorMsg"] = "Unable to save to the database. Please try again later.";

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var disc = await _discService.GetDiscById(id);

            if (disc == null)
            {
                return NotFound();
            }

            return View(disc);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(DiscDetail model)
        {
            if (await _discService.DeleteDisc(model.Id))
            {
                return RedirectToAction(nameof(Index));
            }

            return BadRequest();
        }
    }
}
