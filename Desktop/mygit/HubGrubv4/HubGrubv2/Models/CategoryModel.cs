using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HubGrubv2.Models
{
    public class CategoryModel
    {
        [Key]
        public int RestaurantID { get; set; }
        public string RestaurantCategory { get; set; }
    }
}
