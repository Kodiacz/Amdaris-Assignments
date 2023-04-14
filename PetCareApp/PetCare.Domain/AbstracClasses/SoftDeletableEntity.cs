namespace PetCare.Domain.AbstracClasses
{
    public abstract class SoftDeletableEntity
    {
        public bool IsDeleted { get; set; } = false;
    }
}
