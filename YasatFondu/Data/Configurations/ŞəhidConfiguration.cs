using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Data.Configurations
{
  class ŞəhidConfiguration : IEntityTypeConfiguration<Şəhid>
  {
    public void Configure(EntityTypeBuilder<Şəhid> builder)
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
        Property(m => m.Surname)
        .HasMaxLength(100)
        .IsRequired();

      builder.
        Property(m => m.FathersName)
        .HasMaxLength(100)
        .IsRequired();

      builder.
        Property(m => m.Adress)
        .HasMaxLength(500)
        .IsRequired();

      builder.
        Property(m => m.Contact)
        .HasMaxLength(200)
        .IsRequired();

      builder.
       Property(m => m.FinNom)
       .HasMaxLength(100)
       .IsRequired();

      builder.
       Property(m => m.DistrictDied)
       .HasMaxLength(100)
       .IsRequired();

      builder.
       Property(m => m.DateDied)
       .HasMaxLength(100)
       .IsRequired();

      builder.
       Property(m => m.PhotoPassport)
       .HasMaxLength(200);
      
    }

    
  }
}
