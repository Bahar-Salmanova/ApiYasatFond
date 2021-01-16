using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
  class ŞəhidMedalConfiguration : IEntityTypeConfiguration<ŞəhidMedal>
  {
    public void Configure(EntityTypeBuilder<ŞəhidMedal> builder)
    {
      builder.
        HasKey(m => m.Id);
      builder
         .Property(m => m.Id)
         .ValueGeneratedOnAdd();

      builder.
        Property(m => m.Name)
        .HasMaxLength(100)
        .IsRequired();
      builder.
        HasOne(m => m.Şəhid)
        .WithMany(m => m.ŞəhidMedals)
        .HasForeignKey(m => m.ŞəhidId);


      builder.
        Property(m => m.MedalDate)
        .IsRequired();



    }
  }
}
