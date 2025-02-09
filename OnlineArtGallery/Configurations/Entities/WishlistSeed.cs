using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineArtGallery.Domain;
using System;

namespace OnlineArtGallery.Configurations.Entities
{
    public class WishlistSeed : IEntityTypeConfiguration<Wishlist>
    {
        public void Configure(EntityTypeBuilder<Wishlist> builder)
        {
            builder.HasData(
                new Wishlist
                { 
                    Id = 1,
                    ArtworkId = 0,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Wishlist
                {
                    Id= 2,
                    ArtworkId = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy= "System",
                    UpdatedBy = "System"

                }
            );
           
        }
    }
}
