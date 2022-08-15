using Microsoft.AspNetCore.Mvc;
using TheDiscAppMVC.Models.Collection;
using TheDiscAppMVC.Services.Collection;

namespace TheDiscAppMVC.Controllers
{
    public class CollectionController : Controller
    {
        private readonly ICollectionService _collectionService;
        public CollectionController(ICollectionService collectionService)
        {
            _collectionService = collectionService;
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

        public IActionResult Create()
        {
            return View();
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
