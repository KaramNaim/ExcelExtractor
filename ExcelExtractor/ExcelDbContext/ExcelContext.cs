using System;
using System.Collections.Generic;
using ExcelExtractor.Models;
using Microsoft.EntityFrameworkCore;

namespace ExcelExtractor.ExcelDbContext;

public class ExcelContext : DbContext
{
    public ExcelContext(DbContextOptions<ExcelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ExcelDatum> ExcelData { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ExcelDatum>(entity =>
        {
            entity.Property(e => e.CreatedOn).HasMaxLength(200);
            entity.Property(e => e.ExcelName).HasMaxLength(200);
            entity.Property(e => e.ExcelValue).HasMaxLength(200);
        });

    }

}
