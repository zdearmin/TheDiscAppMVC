using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TheDiscAppMVC.Models.Player;
using TheDiscAppMVC.Models.Team;
using TheDiscAppMVC.Services.Player;
using TheDiscAppMVC.Services.Team;

namespace TheDiscAppMVC.Controllers
{
    public class PlayerController : Controller
    {
        private readonly IPlayerService _playerService;
        private readonly ITeamService _teamService;
        public PlayerController(IPlayerService playerService, ITeamService teamService)
        {
            _playerService = playerService;
            _teamService = teamService;
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

        public async Task<IActionResult> Create()
        {
            var teams = await _teamService.GetAllTeams();

            IEnumerable<SelectListItem> teamSelect = teams
                .Select(t => new SelectListItem()
            {
                Text = t.Name,
                Value = t.Id.ToString()
            });

            PlayerCreate model = new PlayerCreate();

            model.TeamOptions = teamSelect;

            return View(model);
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
                Name = player.Name,
                PdgaNumber = player.PdgaNumber,
                PdgaRating = player.PdgaRating,
                TeamId = player.TeamId
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
