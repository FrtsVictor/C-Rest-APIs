namespace RepoPattern_UnitWork.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}