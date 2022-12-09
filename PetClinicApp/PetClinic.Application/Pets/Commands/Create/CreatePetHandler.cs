﻿namespace PetClinic.Pets.Commands.Create
{
    public class CreatePetHandler : IRequestHandler<CreatePet, Pet>
    {
        private readonly IUnitOfWork unitOfWorkRepo;

        public CreatePetHandler(IUnitOfWork unitOfWorkRepo)
        {
            this.unitOfWorkRepo = unitOfWorkRepo;
        }

        public async Task<Pet> Handle(CreatePet request, CancellationToken cancellationToken)
        {
            Pet pet = new()
            {
                Name = request.Name,
                Age = request.Age,
                Type = request.Type,
                Breed = request.Breed,
                OwnerId = request.OwnerId,
            };

            await this.unitOfWorkRepo.PetRepository.AddAsync(pet);

            return pet;
        }
    }
}