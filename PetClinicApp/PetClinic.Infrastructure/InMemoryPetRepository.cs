namespace PetClinic.Infrastructure
{
    using PetClinic.Application.Contracts;
    using PetClinic.Domain.Entities;

    public class InMemoryPetRepository : IPetRepository
    {
        private readonly ICollection<Pet> _pets = new HashSet<Pet>();

        public void CreatePet(Pet pet)
        {
            this._pets.Add(pet);
            pet.Id = this._pets.Count;
        }
    }
}
