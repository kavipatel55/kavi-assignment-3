namespace Assignment3.model
{
    public class Comment
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public product product { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int Rating { get; set; }
        public List<string> Images { get; set; }
        public string Text { get; set; }
    }

}
