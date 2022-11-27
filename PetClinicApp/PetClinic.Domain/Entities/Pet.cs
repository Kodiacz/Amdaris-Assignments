namespace PetClinic.Domain.Entities
{
    using PetClinic.Domain.AbstracClasses;

    public class Pet : Animal
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}
