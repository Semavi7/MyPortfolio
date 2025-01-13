namespace MyPortfolyo.DAL.Entities
{
    public class Portfolio
    {
        public int PortfolioId { get; set; }
        public string title { get; set; }
        public string SubTitle { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
    }
}
