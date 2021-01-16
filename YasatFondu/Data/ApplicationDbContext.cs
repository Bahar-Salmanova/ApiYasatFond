using Data.Configurations;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class ApplicationDbContext:DbContext
    {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder Builder)
    {
      Builder.ApplyConfiguration(new ŞəhidConfiguration());
      Builder.ApplyConfiguration(new ŞəhidMedalConfiguration());
      Builder.ApplyConfiguration(new ŞəhidOvladıConfiguration()) ;
      Builder.ApplyConfiguration(new HomeİnformationConfiguration());

    }
    public DbSet<Şəhid> Şəhids { get; set; }
    public DbSet<ŞəhidMedal> ŞəhidMedals { get; set; }
    public DbSet<ŞəhidOvladi> ŞəhidOvlads { get; set; }
    public DbSet<Homeİnformation> Homeİnformations { get; set; }

  }
}
