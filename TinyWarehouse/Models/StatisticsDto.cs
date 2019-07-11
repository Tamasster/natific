using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TinyWarehouse.Models
{
    public class StatisticsDto
    {
        public decimal? WeightSum { get; set; }
        public decimal? PriceSum { get; set; }
        public InventoryItemDto HasMost { get; set; }
        public PartDto Weightest { get; set; }
    }
}