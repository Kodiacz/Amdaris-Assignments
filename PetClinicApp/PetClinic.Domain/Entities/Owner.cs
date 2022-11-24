namespace PetClinic.Domain.Entities
{
    using PetClinic.Domain.AbstracClasses;

    public class Owner : Person
    {
        public Owner()
        {
            this.Pets = new HashSet<Pet>();
        }

        public int Id { get; set; }

        public ICollection<Pet> Pets { get; set; }

    }
}
