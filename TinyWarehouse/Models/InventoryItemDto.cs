using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TinyWarehouse.Models
{
    public class InventoryItemDto
    {
        public string PartNumber { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public decimal? Weight { get; set; }
        public int Quantity { get; set; }
    }
}