using MediatR;
namespace PetClinic.Application.Pets.Commands.CreatePet
{
    using PetClinic.Application.Contracts;
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

            this._petRepository.CreatePet(pet);
            return Task.FromResult(pet.Id);
        }
    }
}
