using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Configurations
{
  class HomeİnformationConfiguration : IEntityTypeConfiguration<Homeİnformation>
  {
    public void Configure(EntityTypeBuilder<Homeİnformation> builder)
    {
      builder.HasKey(m => m.Id);
      builder
         .Property(m => m.Id)
         .ValueGeneratedOnAdd();
      builder.
       Property(m => m.HomeDocument)
       .IsRequired();

      builder.
       Property(m => m.PersonPrice)
       .IsRequired();
      builder.
       Property(m => m.AreaKvMetr)
       .IsRequired();
      builder.
       Property(m => m.RoomQuantity)
       .HasMaxLength(100)
       .IsRequired();

      builder.
      Property(m => m.RoomPhoto)
      .IsRequired();
      builder.
        HasOne(m => m.Şəhid)
        .WithMany(m => m.Homeİnformation)
        .HasForeignKey(m => m.ŞəhidId);


    }
  }
}
