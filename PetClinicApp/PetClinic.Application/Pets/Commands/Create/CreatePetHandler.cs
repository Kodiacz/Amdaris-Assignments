namespace PetClinic.Application.Pets.Commands.Create
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
            if (await this.unitOfWorkRepo.OwnerRepository.GetByIdAsync(request.OwnerId) == null)
            {
                throw new NotExistException("Owner with this ID doest not exist in the database");
            }

            Pet pet = new()
            {
                Name = request.Name,
                Age = request.Age,
                Type = request.Type,
                Breed = request.Breed,
                OwnerId = request.OwnerId,
            };

            await this.unitOfWorkRepo.PetRepository.AddAsync(pet);
            await this.unitOfWorkRepo.SaveAsync();

            return pet;
        }
    }
}
