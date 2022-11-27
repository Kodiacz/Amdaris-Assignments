namespace PetClinic.Infrastructure
{
    using PetClinic.Application.Contracts;
    using PetClinic.Domain.Entities;

    public class InMemoryPetRepository : IPetRpository
    {
        private readonly ICollection<Pet> _pets;

        public InMemoryPetRepository(ICollection<Pet> pets)
        {
            _pets = pets;
        }

        public void CreatePet(Pet pet)
        {
            this._pets.Add(pet);
            pet.Id = this._pets.Count;
        }
    }
}
