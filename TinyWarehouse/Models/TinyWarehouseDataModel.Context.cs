﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TinyWarehouse.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TinyWarehouseDB : DbContext
    {
        public TinyWarehouseDB()
            : base("name=TinyWarehouseDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<inventory> inventory { get; set; }
        public virtual DbSet<part> part { get; set; }
        public virtual DbSet<transaction> transaction { get; set; }
    }
}