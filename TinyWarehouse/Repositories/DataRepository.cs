using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TinyWarehouse.Models;

namespace TinyWarehouse.Repositories
{
    public class DataRepository
    {
        private readonly TinyWarehouseDB ctx;

        public DataRepository()
        {
            ctx = new TinyWarehouseDB();
        }

        public List<InventoryItemDto> GetFullInventory()
        {
            return ctx.inventory.Join(ctx.part,
                inv => inv.part_id,
                prt => prt.Id,
                (inv, prt) => new InventoryItemDto
                {
                    Quantity = inv.quantity,
                    Name = prt.name,
                    Description = prt.description,
                    PartNumber = prt.part_number,
                    Price = prt.price,
                    Weight = prt.weight
                }).ToList();
        }

    }
}