namespace Domain.DDD_API.Domain.Entities
{
    public class Product : Base
    {
        public string Name { get; set; }
        public decimal value { get; set; }
        public bool IsAvaiable { get; set; }
    }
}