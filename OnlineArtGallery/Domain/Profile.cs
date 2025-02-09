using Microsoft.AspNetCore.Identity;

namespace OnlineArtGallery.Domain
{
    public class Profile : BaseDomainModel
    {
        public string? Name { get; set; }
        //public string? UserName { get; set; }
        public string? Description { get; set; }
        public string? ImagePath { get; set; }
    }
}
