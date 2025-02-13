﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using UT02_02_Hibrido.Models;

namespace UT02_02_Hibrido.Data;

public partial class NorthwindContext : DbContext
{
    public NorthwindContext(DbContextOptions<NorthwindContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Shipper> Shippers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Shipper>().ToTable("Shipper", t=>t.ExcludeFromMigrations());
        OnModelCreatingPartial(modelBuilder);
        
        modelBuilder.Entity<Company>().HasData(
            new Company
            {
                Id = 1,
                Name = "Mcdonal",
                Description = "Seat",
                ShipperID = 1,

            },
              new Company
              {
                  Id = 2,
                  Name = "Panda",
                  Description = "Seat",
                  ShipperID = 2
              },
                new Company
                {
                    Id = 3,
                    Name = "Panda",
                    Description = "Seat",
                    ShipperID = 3
                }

            );
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

public DbSet<UT02_02_Hibrido.Models.Company> Company { get; set; } = default!;
}