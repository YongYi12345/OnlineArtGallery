
using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineArtGallery.Domain
{
    public class Artwork : BaseDomainModel
    {
        public int ProfileId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public string? ImagePath { get; set; }
        //public bool Likes { get; set; }
    }
}
