using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineArtGallery.Domain;
using System.Drawing;

namespace OnlineArtGallery.Configurations.Entities
{
    public class ArtworkSeed : IEntityTypeConfiguration<Artwork>
    {
        public void Configure(EntityTypeBuilder<Artwork> builder)
        {
            builder.HasData(
                new Artwork
{
                    Id = 1,
                    Name = "Monkey",
                    Description = "A Monkey",
                    Price = 0.01,
                    Image = "idkhowtoshowimage",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
}
);
        }
    }
}
