namespace OnlineArtGallery.Domain
{
    public class Comment : BaseDomainModel
    {
        public int DiscussionId { get; set; }
        public int ProfileId { get; set; }
        public string? Text { get; set; }
    }
}
