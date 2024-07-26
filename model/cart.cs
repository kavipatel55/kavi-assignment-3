namespace Assignment3.model
{
    public class cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<product> products { get; set; }
        public List<int> Quantities { get; set; }
    }
}
