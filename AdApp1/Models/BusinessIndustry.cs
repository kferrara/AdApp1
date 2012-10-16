namespace AdApp1.Models
{
    class BusinessIndustry
    {
        public int BusinessIndustryId { get; set; }
        public virtual Business Business { get; set; }
        public virtual Industry Industry { get; set; }
    }
}