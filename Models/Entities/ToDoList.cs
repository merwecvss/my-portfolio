namespace my_portfolio.Models.Entities
{
    public class ToDoList
    {
        public int ToDoListId { get; set; }
        public string Title { get; set; }
        public string İmageUrl { get; set; }
        public DateTime Time { get; set; }
        public bool Status { get; set; }
    }
}