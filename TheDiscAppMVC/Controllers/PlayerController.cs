using Microsoft.AspNetCore.Mvc;
using TheDiscAppMVC.Models.Player;
using TheDiscAppMVC.Services.Player;

namespace TheDiscAppMVC.Controllers
{
    public class PlayerController : Controller
    {
        private readonly IPlayerService _playerService;
        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        public async Task<IActionResult> Index()
        {
            var players = await _playerService.GetAllPlayers();
            return View(players);
        }

        public async Task<IActionResult> Details(int id)
        {
            var player = await _playerService.GetPlayerById(id);

            if (player == null)
            {
                return NotFound();
            }

            return View(player);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PlayerCreate model)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorMsg"] = "Model State is Invalid";
                return View(ModelState);
            }

            bool wasCreated = await _playerService.CreatePlayer(model);

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
            PlayerDetail player = await _playerService.GetPlayerById(id);

            if (player == null)
            {
                return NotFound();
            }

            var playerEdit = new PlayerEdit
            {
                Id = player.Id,
                Name = player.Name
            };

            return View(playerEdit);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, PlayerEdit model)
        {
            if (id != model.Id || !ModelState.IsValid)
            {
                return View(ModelState);
            }

            bool wasUpdated = await _playerService.UpdatePlayer(model);

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
            var player = await _playerService.GetPlayerById(id);

            if (player == null)
            {
                return NotFound();
            }

            return View(player);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(PlayerDetail model)
        {
            if (await _playerService.DeletePlayer(model.Id))
            {
                return RedirectToAction(nameof(Index));
            }

            return BadRequest();
        }
    }
}
