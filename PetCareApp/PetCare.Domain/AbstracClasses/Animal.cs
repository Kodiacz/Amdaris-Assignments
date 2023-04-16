namespace PetCare.Domain.AbstracClasses
{
    public abstract class Animal : SoftDeletableEntity
    {
        public string Breed { get; set; }

        public string Type { get; set; }
    }
}
