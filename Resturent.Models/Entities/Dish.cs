using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturent.Models.Entities
{
    public class Dish
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; }= default!;
        public decimal Price { get; set; } = default!;
        public Guid ResturentId { get; set; }
        public int? KiloCalories { get; set; }

    }
}
