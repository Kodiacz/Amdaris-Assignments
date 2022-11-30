using MediatR;
namespace PetClinic.Pets.Commands.CreatePet
{
    using PetClinic.Interfaces;
    using PetClinic.Domain.Entities;

    public class CreatePetHandler : IRequestHandler<CreatePetCommand, int>
    {
        IPetRepository _petRepository;

        public CreatePetHandler(IPetRepository petRepository)
        {
            this._petRepository = petRepository;
        }

        public Task<int> Handle(CreatePetCommand request, CancellationToken cancellationToken)
        {
            Pet pet = new Pet
            {
                Name = request.Name,
                Breed = request.Breed,
                Age = request.Age,
                OwnerId = request.OwnerId,
            };


            return Task.FromResult(pet.Id);
        }
    }
}
