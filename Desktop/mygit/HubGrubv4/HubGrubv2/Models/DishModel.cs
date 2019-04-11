using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HubGrubv2.Models
{
    public class DishModel
    {
        [Key]
        public int DishID { get; set; }
        public int RestaurantID { get; set; }
        public string DishName { get; set; }
        public double DishPrice { get; set; }
    }
}
