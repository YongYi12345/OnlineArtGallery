namespace OnlineArtGallery.Domain
{
    public class Auction : BaseDomainModel
    {
        public int StartingBid { get; set; }
        public int HighestBid { get; set; }
        public double Description { get; set; }

        public string?  Image {  get; set; }
        public double Date { get; set; }

    }
}
