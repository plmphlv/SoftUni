using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SeminarHub.Data;
using SeminarHub.Data.Models;
using SeminarHub.Models;
using System.Globalization;
using System.Security.Claims;

namespace SeminarHub.Controllers
{
    [Authorize]
    public class SeminarController : Controller
    {
        private readonly SeminarHubDbContext data;

        public SeminarController(SeminarHubDbContext context)
        {
            data = context;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var seminars = await data.Seminars.AsNoTracking()
                .Select(s => new SeminarInfoViewModel
                {
                    Id = s.Id,
                    Topic = s.Topic,
                    Lecturer = s.Lecturer,
                    Category = s.Category.Name,
                    DateAndTime = s.DateAndTime.ToString(DataConstants.DateRequiredFormat),
                    Organizer = s.Organizer.UserName
                }).ToListAsync();

            return View(seminars);
        } // Displays all seminars that are in the database

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new SeminarFormViewModel();
            model.Categories = await GetCategories();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(SeminarFormViewModel model)
        {
            DateTime dateAndTime = DateTime.Now;

            if (!DateTime.TryParseExact(
                model.DateAndTime,
                DataConstants.DateRequiredFormat,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out dateAndTime))
            {
                ModelState
                    .AddModelError(nameof(model.DateAndTime), $"Invalid date! Format must be: {DataConstants.DateRequiredFormat}");
            }

            if (!ModelState.IsValid)
            {
                model.Categories = await GetCategories();

                return View(model);
            }

            string organizerId = GetUserId();

            var newSeminar = new Seminar(model.Topic, model.Lecturer, model.Details, organizerId, dateAndTime, model.Duration, model.CategoryId);

            await data.Seminars.AddAsync(newSeminar);
            await data.SaveChangesAsync();

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var model = await data.Seminars
                .Where(s => s.Id == id)
                .AsNoTracking()
                .Select(s => new SeminarInfoViewModel()
                {
                    Id = s.Id,
                    Topic = s.Topic,
                    DateAndTime = s.DateAndTime.ToString(DataConstants.DateRequiredFormat), //Seminar starting time
                    Duration = s.Duration, //Seminar time
                    Lecturer = s.Lecturer,
                    Category = s.Category.Name,
                    Details = s.Details,
                    Organizer = s.Organizer.UserName
                })
                .FirstOrDefaultAsync();

            if (model == null)
            {
                return BadRequest();
            }

            return View(model);
        } // Displays seminar details

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var seminar = await data.Seminars.FindAsync(id);

            if (seminar == null)
            {
                return BadRequest();
            }

            if (seminar.OrganizerId != GetUserId())
            {
                return Unauthorized();
            }

            var model = new SeminarFormViewModel()
            {
                Id = id,
                Topic = seminar.Topic,
                Lecturer = seminar.Lecturer,
                Details = seminar.Details,
                DateAndTime = seminar.DateAndTime.ToString(DataConstants.DateRequiredFormat),
                Duration = seminar.Duration,
                CategoryId = seminar.CategoryId
            };

            model.Categories = await GetCategories();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SeminarFormViewModel model, int id)
        {
            var seminar = await data.Seminars.FindAsync(id);

            if (seminar == null)
            {
                return BadRequest();
            }

            if (seminar.OrganizerId != GetUserId())
            {
                return Unauthorized();
            }

            DateTime dateAndTime = DateTime.Now;

            if (!DateTime.TryParseExact(
                model.DateAndTime,
                DataConstants.DateRequiredFormat,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out dateAndTime))
            {
                ModelState
                    .AddModelError(nameof(model.DateAndTime), $"Invalid date! Format must be: {DataConstants.DateRequiredFormat}");
            }

            if (!ModelState.IsValid)
            {
                model.Categories = await GetCategories();

                return View(model);
            }

            seminar.Topic = model.Topic;
            seminar.Lecturer = model.Lecturer;
            seminar.Details = model.Details;
            seminar.DateAndTime = dateAndTime;
            seminar.Duration = model.Duration;
            seminar.CategoryId = model.CategoryId;

            await data.SaveChangesAsync();

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Joined()
        {
            string userId = GetUserId();

            var model = await data.SeminarParticipants
                .Where(sp => sp.ParticipantId == userId)
                .AsNoTracking()
                .Select(sp =>
            new SeminarInfoViewModel()
            {
                Id = sp.SeminarId,
                Topic = sp.Seminar.Topic,
                Lecturer = sp.Seminar.Lecturer,
                Details = sp.Seminar.Details,
                Category = sp.Seminar.Category.Name,
                DateAndTime = sp.Seminar.DateAndTime.ToString(DataConstants.DateRequiredFormat),
                Duration = sp.Seminar.Duration,
                Organizer = sp.Seminar.OrganizerId
            })
                .ToListAsync();

            return View(model);
        }

        public async Task<IActionResult> Join(int id)
        {
            string userId = GetUserId();

            var model = await data.Seminars
                .Where(s => s.Id == id)
                .Include(s => s.SeminarsParticipants)
                .FirstOrDefaultAsync();

            if (model == null)
            {
                return BadRequest();
            }

            if (!model.SeminarsParticipants.Any(p => p.ParticipantId == userId))
            {
                SeminarParticipant participant = new SeminarParticipant(id, userId);

                model.SeminarsParticipants.Add(participant);

                await data.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Joined));
        }

        public async Task<IActionResult> Leave(int id)
        {
            string userId = GetUserId();

            var seminar = await data.Seminars
                .Include(sp => sp.SeminarsParticipants)
                .FirstOrDefaultAsync(sp => sp.Id == id);

            if (seminar == null)
            {
                return BadRequest();
            }

            var seminarParticipant = seminar.SeminarsParticipants.FirstOrDefault(sp => sp.ParticipantId == userId);

            if (seminarParticipant == null)
            {
                return BadRequest();
            }

            seminar.SeminarsParticipants.Remove(seminarParticipant);
            await data.SaveChangesAsync();
            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var model = await data.Seminars
                .Where(s => s.Id == id)
                .AsNoTracking()
                .Select(s => new SeminarDeleteViewModel()
                {
                    Id = s.Id,
                    DateAndTime = s.DateAndTime,
                    Topic = s.Topic,
                    OrganizerId = s.OrganizerId,
                })
                .FirstOrDefaultAsync();

            if (model == null)
            {
                return BadRequest();
            }

            if (model.OrganizerId != GetUserId())
            {
                return Unauthorized();
            }

            return View(model);
        }

        [HttpPost, ActionName("DeleteConfirmed")]
        public async Task<IActionResult> Delete(SeminarDeleteViewModel viewModel, int id)
        {
            var seminar = await data.Seminars
                .Where(s => s.Id == id)
                .Include(s => s.SeminarsParticipants)
                .FirstOrDefaultAsync();

            if (seminar == null)
            {
                return BadRequest();
            }

            if (seminar.OrganizerId != GetUserId())
            {
                return Unauthorized();
            }

            seminar.SeminarsParticipants.Clear();
            data.Seminars.Remove(seminar);

            await data.SaveChangesAsync();

            return RedirectToAction(nameof(All));
        } // Deletes the selected seminar from the database along with all of it's participants

        private string GetUserId()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
        } // Get the user id of the current logged in user

        private async Task<IEnumerable<CategoryViewModel>> GetCategories()
        {
            return await data.Categories
                .AsNoTracking()
                .Select(et => new CategoryViewModel()
                {
                    Id = et.Id,
                    Name = et.Name,
                })
                .ToListAsync();

        } // Gets all available categories from the database for seminar creation or editing
    }
}
