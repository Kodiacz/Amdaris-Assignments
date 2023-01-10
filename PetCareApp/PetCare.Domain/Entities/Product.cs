namespace PetCare.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string ProductName { get; set; } = null!;

        public Category Category { get; set; } = null!;
    }
}
