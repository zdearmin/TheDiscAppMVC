using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TheDiscAppMVC.Models.Team;
using TheDiscAppMVC.Services.Player;
using TheDiscAppMVC.Services.Team;

namespace TheDiscAppMVC.Controllers
{
    public class TeamController : Controller
    {
        private readonly ITeamService _teamService;
        private readonly IPlayerService _playerService;
        public TeamController(ITeamService teamService, IPlayerService playerService)
        {
            _teamService = teamService;
            _playerService = playerService;
        }

        public async Task<IActionResult> Index()
        {
            var teams = await _teamService.GetAllTeams();
            return View(teams);
        }

        public async Task<IActionResult> Details(int id)
        {
            var team = await _teamService.GetTeamById(id);

            if (team == null)
            {
                return NotFound();
            }

            return View(team);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TeamCreate model)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorMsg"] = "Model State is Invalid";
                return View(ModelState);
            }

            bool wasCreated = await _teamService.CreateTeam(model);

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
            TeamDetail team = await _teamService.GetTeamById(id);

            if (team == null)
            {
                return NotFound();
            }

            var teamEdit = new TeamEdit
            {
                Id = team.Id,
                Name = team.Name
            };

            return View(teamEdit);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, TeamEdit model)
        {
            if (id != model.Id || !ModelState.IsValid)
            {
                return View(ModelState);
            }

            bool wasUpdated = await _teamService.UpdateTeam(model);

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
            var team = await _teamService.GetTeamById(id);

            if (team == null)
            {
                return NotFound();
            }

            return View(team);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(TeamDetail model)
        {
            if (await _teamService.DeleteTeam(model.Id))
            {
                return RedirectToAction(nameof(Index));
            }

            return BadRequest();
        }
    }
}
