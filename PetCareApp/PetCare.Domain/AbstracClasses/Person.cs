namespace PetCare.Domain.AbstracClasses
{
    public abstract class Person
    {
        public string FirstName { get; init; }

        public string LastName { get; init; }

        public int? Age { get; init; }

        public string Phonenumber { get; init; }
    }
}
