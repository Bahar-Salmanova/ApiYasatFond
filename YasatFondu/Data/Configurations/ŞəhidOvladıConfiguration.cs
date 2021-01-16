using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
  class ŞəhidOvladıConfiguration : IEntityTypeConfiguration<ŞəhidOvladi>

  {
    public void Configure(EntityTypeBuilder<ŞəhidOvladi> builder)
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

      builder.Property(m => m.Surname)
        .HasMaxLength(150)
        .IsRequired();

      builder.Property(m => m.FinCode)
        .HasMaxLength(100)
        .IsRequired();

      builder.Property(m => m.Gender)
        .HasMaxLength(50)
        .IsRequired();

      builder.Property(m => m.Birthday)
        .IsRequired();

      builder.Property(m => m.PassportPhoto)
        .HasMaxLength(200)
        .IsRequired();

      builder.
        HasOne(m => m.Şəhid)
        .WithMany(m => m.ŞəhidOvladis)
        .HasForeignKey(m => m.ŞəhidId);
    
    }
  }
}
