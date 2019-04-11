using HubGrubv2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace HubGrubv2.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly AppDbContext _context;

        public RestaurantController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Restaurant
        public async Task<IActionResult> Index()
        {
            return View();
        }

        // GET: Restaurant/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurantModel = await _context.RestaurantModel
                .FirstOrDefaultAsync(m => m.RestaurantID == id);
            if (restaurantModel == null)
            {
                return NotFound();
            }

            return View(restaurantModel);
        }

        // GET: Restaurant/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Restaurant/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RestaurantID,RestaurantName,RestaurantHours,RestaurantAddress,RestaurantPhoneNumber")] RestaurantModel restaurantModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(restaurantModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(restaurantModel);
        }

        // GET: Restaurant/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurantModel = await _context.RestaurantModel.FindAsync(id);
            if (restaurantModel == null)
            {
                return NotFound();
            }
            return View(restaurantModel);
        }

        // POST: Restaurant/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RestaurantID,RestaurantName,RestaurantHours,RestaurantAddress,RestaurantPhoneNumber")] RestaurantModel restaurantModel)
        {
            if (id != restaurantModel.RestaurantID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(restaurantModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RestaurantModelExists(restaurantModel.RestaurantID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(restaurantModel);
        }

        // GET: Restaurant/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurantModel = await _context.RestaurantModel
                .FirstOrDefaultAsync(m => m.RestaurantID == id);
            if (restaurantModel == null)
            {
                return NotFound();
            }

            return View(restaurantModel);
        }

        // POST: Restaurant/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var restaurantModel = await _context.RestaurantModel.FindAsync(id);
            _context.RestaurantModel.Remove(restaurantModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RestaurantModelExists(int id)
        {
            return _context.RestaurantModel.Any(e => e.RestaurantID == id);
        }
    }
}
