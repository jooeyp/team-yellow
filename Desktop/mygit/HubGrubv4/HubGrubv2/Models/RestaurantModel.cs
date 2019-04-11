using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HubGrubv2.Models
{
    public class RestaurantModel
    {
        [Key]
        public int RestaurantID { get; set; }
        public string RestaurantName { get; set; }
        public string RestaurantHours { get; set; }
        public string RestaurantAddress { get; set; }
        public int RestaurantPhoneNumber { get; set; }
    }
}


