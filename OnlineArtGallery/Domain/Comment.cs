namespace OnlineArtGallery.Domain
{
    public class Comment : BaseDomainModel
    {
        public int DiscussionId { get; set; }
        public string? Text { get; set; }
    }
}
