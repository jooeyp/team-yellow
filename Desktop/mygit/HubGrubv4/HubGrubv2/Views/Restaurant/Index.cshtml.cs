using HubGrubv2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HubGrubv2.Views.Restaurant
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;
        
        public IndexModel(HubGrubv2.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<RestaurantModel> Restaurants { get; private set; }

        public async Task OnGetAsync()
        {
            Restaurants = await _context.RestaurantModel.ToListAsync();
        }
    }
}