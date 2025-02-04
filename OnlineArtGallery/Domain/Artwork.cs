
using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineArtGallery.Domain
{
    public class Artwork : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public string? ImagePath { get; set; }
        [NotMapped]
        public IBrowserFile? Image { get; set; }
    }
}
