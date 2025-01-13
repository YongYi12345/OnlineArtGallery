using Microsoft.AspNetCore.Components.QuickGrid;
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
                    Name = "Name of Artwork",
                    Description = "A Description of Artwork",
                    Price = 0.00,
                    Image = "https://th.bing.com/th/id/OIP.GPFEY6kfgxbsja6gmrW6rwHaE7?w=270&h=180&c=7&r=0&o=5&dpr=1.5&pid=1.7",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"

                }
);
        }
    }
}
