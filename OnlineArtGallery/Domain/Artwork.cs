using Microsoft.AspNetCore.Mvc.TagHelpers;
using System.Drawing;

namespace OnlineArtGallery.Domain
{
    public class Artwork : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public string? Image { get; set; }
    }
}
