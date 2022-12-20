namespace PetCare.Application.Pets.Commands.Update
{
    public class UpdatePetHandler : IRequestHandler<UpdatePet, Pet>
    {
        private readonly IUnitOfWork unitOfWorkRepo;

        public UpdatePetHandler(IUnitOfWork unitOfWorkRepo)
        {
            this.unitOfWorkRepo = unitOfWorkRepo;
        }

        public async Task<Pet> Handle(UpdatePet request, CancellationToken cancellationToken)
        {
            Pet pet = new()
            {
                Id = request.Id,
                Name = request.Name,
                Age = request.Age,
                Type = request.Type,
                Breed = request.Breed,
                OwnerId = request.OwnerId,
            };

            await this.unitOfWorkRepo.PetRepository.UpdateAsync(pet);
            await this.unitOfWorkRepo.SaveAsync();

            return pet;
        }
    }
}
