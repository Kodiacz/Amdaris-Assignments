using PetCare.Application.Pets.Commands.Update;

namespace PetCare.Application.Pets.Commands.PartialUpdate
{
    public class PartialUpdatePetHendler : IRequestHandler<PartialUpdatePet, Pet>
    {
        private readonly IUnitOfWork unitOfWorkRepo;

        public PartialUpdatePetHendler(IUnitOfWork unitOfWorkRepo)
        {
            this.unitOfWorkRepo = unitOfWorkRepo;
        }

        public async Task<Pet> Handle(PartialUpdatePet request, CancellationToken cancellationToken)
        {
            Pet owner = new Pet
            {
                Id = request.Id,
                Name = request.Name,
                Type = request.Type,
                Age = request.Age,
                Breed = request.Breed,
            };

            await this.unitOfWorkRepo.PetRepository.UpdateAsync(owner);
            await this.unitOfWorkRepo.SaveAsync();

            return owner;
        }
    }
}
