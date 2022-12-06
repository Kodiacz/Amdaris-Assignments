namespace PetClinic.Domain.AbstracClasses
{
    public abstract class Animal
    {
        public string Breed { get; set; }

        public string Type { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
