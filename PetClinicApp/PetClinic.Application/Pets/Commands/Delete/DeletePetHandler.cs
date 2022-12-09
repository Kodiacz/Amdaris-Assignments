namespace PetClinic.Application.Pets.Commands.Delete
{
    public class DeletePetHandler : IRequestHandler<DeletePet, Pet>
    {
        private readonly IUnitOfWork unitOfWorkRepo;

        public DeletePetHandler(IUnitOfWork unitOfWorkRepo)
        {
            this.unitOfWorkRepo = unitOfWorkRepo;
        }

        public async Task<Pet> Handle(DeletePet request, CancellationToken cancellationToken)
        {
            Pet pet = await this.unitOfWorkRepo.PetRepository.GetByIdAsync(request.Id);

            if (!pet.IsDeleted)
            {
                pet.IsDeleted = true;
            }
            else
            {
                throw new AlreadyDeletedException("This Pet is already deleted");
            }

            await this.unitOfWorkRepo.SaveAsync();

            return pet;
        }
    }
}
