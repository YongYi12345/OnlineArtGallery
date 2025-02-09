using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineArtGallery.Configurations.Entities;
using OnlineArtGallery.Data;
using OnlineArtGallery.Domain;

namespace OnlineArtGallery.Data
{
    public class OnlineArtGalleryContext(DbContextOptions<OnlineArtGalleryContext> options) : IdentityDbContext<OnlineArtGalleryUser>(options)
    {

        public DbSet<OnlineArtGallery.Domain.Artwork> Artwork { get; set; } = default!;
        public DbSet<OnlineArtGallery.Domain.Wishlist> Wishlist { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);



            
            builder.ApplyConfiguration(new UserSeed());
        }
        public DbSet<OnlineArtGallery.Domain.Auction> Auction { get; set; } = default!;
        public DbSet<OnlineArtGallery.Domain.Discussion> Discussion { get; set; } = default!;
        public DbSet<OnlineArtGallery.Domain.Comment> Comment { get; set; } = default!;     
       
    }

}
      
        

    
