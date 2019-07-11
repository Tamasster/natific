using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TinyWarehouse.Models
{
    public class InventoryItemDto : PartDto
    {
        public int Quantity { get; set; }
    }
}