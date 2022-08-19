using Microsoft.AspNetCore.Mvc;
using TheDiscAppMVC.Models.Collection;
using TheDiscAppMVC.Services.Collection;
using TheDiscAppMVC.Services.Player;
using TheDiscAppMVC.Services.Disc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TheDiscAppMVC.Controllers
{
    public class CollectionController : Controller
    {
        private readonly ICollectionService _collectionService;
        private readonly IPlayerService _playerService;
        private readonly IDiscService _discService;
        public CollectionController(ICollectionService collectionService, IPlayerService playerService, IDiscService discService)
        {
            _collectionService = collectionService;
            _playerService = playerService;
            _discService = discService;
        }

        public async Task<IActionResult> Index()
        {
            var collections = await _collectionService.GetAllCollections();
            return View(collections);
        }

        public async Task<IActionResult> Details(int id)
        {
            var collection = await _collectionService.GetCollectionById(id);

            if (collection == null)
            {
                return NotFound();
            }

            return View(collection);
        }

        public async Task<IActionResult> Create()
        {
            var players = await _playerService.GetAllPlayers();
            var discs = await _discService.GetAllDiscs();

            IEnumerable<SelectListItem> playerSelect = players
                .Select(t => new SelectListItem()
                {
                    Text = t.Name,
                    Value = t.Id.ToString()
                });

            IEnumerable<SelectListItem> discSelect = discs
                .Select(t => new SelectListItem()
                {
                    Text = t.Name,
                    Value = t.Id.ToString()
                });

            CollectionCreate model = new CollectionCreate();

            model.PlayerOptions = playerSelect;
            model.DiscOptions = discSelect;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CollectionCreate model)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorMsg"] = "Model State is Invalid";
                return View(ModelState);
            }

            bool wasCreated = await _collectionService.CreateCollection(model);

            if (wasCreated)
            {
                return RedirectToAction(nameof(Index));
            }

            TempData["ErrorMsg"] = "Unable to save to the database. Please try again later.";

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            CollectionDetail collection = await _collectionService.GetCollectionById(id);

            if (collection == null)
            {
                return NotFound();
            }

            var collectionEdit = new CollectionEdit
            {
                Id = collection.Id,
                Name = collection.Name,
            };

            return View(collectionEdit);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, CollectionEdit model)
        {
            if (id != model.Id || !ModelState.IsValid)
            {
                return View(ModelState);
            }

            bool wasUpdated = await _collectionService.UpdateCollection(model);

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
            var collection = await _collectionService.GetCollectionById(id);

            if (collection == null)
            {
                return NotFound();
            }

            return View(collection);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(CollectionDetail model)
        {
            if (await _collectionService.DeleteCollection(model.Id))
            {
                return RedirectToAction(nameof(Index));
            }

            return BadRequest();
        }
    }
}
