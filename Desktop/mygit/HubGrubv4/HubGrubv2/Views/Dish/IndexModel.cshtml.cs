using HubGrubv2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace HubGrubv2.Views.Dish
{
    public class IndexModelModel : PageModel
    {
        private readonly AppDbContext _context;

        public object DishModel { get; private set; }

        public IndexModelModel(HubGrubv2.Models.AppDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            DishModel = await _context.RestaurantModel.FirstOrDefaultAsync(m => m.RestaurantID == id);

            if (DishModel == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}