using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlineArtGallery.Data;

namespace OnlineArtGallery.Data
{
    public class OnlineArtGalleryContext(DbContextOptions<OnlineArtGalleryContext> options) : IdentityDbContext<OnlineArtGalleryUser>(options)
    {

        public DbSet<OnlineArtGallery.Domain.User> User { get; set; } = default!;
    }
}
