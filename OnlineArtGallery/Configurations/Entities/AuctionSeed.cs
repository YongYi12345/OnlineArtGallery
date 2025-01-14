using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineArtGallery.Domain;

namespace OnlineArtGallery.Configurations.Entities
{
    public class AuctionSeed : IEntityTypeConfiguration<Auction>
    {
        public void Configure(EntityTypeBuilder<Auction> builder)
        {
            builder.HasData(
                new Auction
                {
                    Id = 888,
                    StartingBid = 1,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },



                new Auction
                {
                    Id = 999,
                    StartingBid = 2,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }



            );
        }
    }
}
        
    

