namespace PetCare.Domain.Entities
{
    public class Category
    {
        public Category()
        {
            this.Products = new HashSet<Product>();
        }

        public int Id { get; set; }

        public string CategoryName { get; set; } = null!;

        public ICollection<Product> Products { get; set; }
    }
}
