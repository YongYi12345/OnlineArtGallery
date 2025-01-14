using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineArtGallery.Configurations.Entities;
using OnlineArtGallery.Data;
using OnlineArtGallery.Domain;

namespace OnlineArtGallery.Data
{
    public class OnlineArtGalleryContext(DbContextOptions<OnlineArtGalleryContext> options) : IdentityDbContext<OnlineArtGalleryUser>(options)
    {

        public DbSet<OnlineArtGallery.Domain.User> User { get; set; } = default!;
        public DbSet<OnlineArtGallery.Domain.Artwork> Artwork { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ArtworkSeed());
            builder.ApplyConfiguration(new AuctionSeed());
        }
        public DbSet<OnlineArtGallery.Domain.Auction> Auction { get; set; } = default!;

    }
}
