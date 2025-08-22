namespace my_portfolio.Models.Entities
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        public string NameSurname { get; set; }
        public int Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}