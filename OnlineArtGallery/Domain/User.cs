namespace OnlineArtGallery.Domain
{
    public class User : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public int Contact { get; set; }
        public string? Role { get; set; }
    }
}
