namespace Assignment3.model
{
    public class order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime OrderDate { get; set; }
        public List<product> products { get; set; }
        public List<int> Quantities { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
