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
                }).OrderBy(a => a.Name).ToList();
        }

        public List<PartDto> GetParts()
        {
            return ctx.part.Select(prt => new PartDto
            {
                Name = prt.name,
                Description = prt.description,
                PartNumber = prt.part_number,
                Price = prt.price,
                Weight = prt.weight
            }).OrderBy(a => a.PartNumber).ToList();
        }

        public decimal? WeightSum()
        {
            return ctx.inventory.Join(ctx.part,
               inv => inv.part_id,
               prt => prt.Id,
               (inv, prt) => new 
               {
                   pSum = inv.quantity * prt.weight
               }).Sum(a => a.pSum);
        }

        public decimal? PriceSum()
        {
            return ctx.inventory.Join(ctx.part,
               inv => inv.part_id,
               prt => prt.Id,
               (inv, prt) => new
               {
                   pSum = inv.quantity * prt.price
               }).Sum(a => a.pSum);
        }

        public InventoryItemDto HasMost()
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
               }).OrderByDescending(a => a.Quantity).First();
        }

        public PartDto Weightest()
        {
            return ctx.part.Select(
                a => new PartDto
                {
                    Description = a.description,
                    Name = a.name,
                    PartNumber = a.part_number,
                    Price = a.price,
                    Weight = a.weight
                }
                ).OrderByDescending(a => a.Weight).First();
        }

    }
}