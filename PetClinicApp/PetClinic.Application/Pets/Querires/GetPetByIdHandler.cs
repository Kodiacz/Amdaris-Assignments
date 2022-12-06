namespace PetClinic.Application.Pets.Querires
{
    public class GetPetByIdHandler : IRequestHandler<GetPetById, Pet>
    {
        private readonly IUnitOfWork unitOfWorkRepo;

        public GetPetByIdHandler(IUnitOfWork unitOfWorkRepo)
        {
            this.unitOfWorkRepo = unitOfWorkRepo;
        }

        public async Task<Pet> Handle(GetPetById request, CancellationToken cancellationToken)
        {
            return await this.unitOfWorkRepo.PetRepository.GetByIdAsync(request.Id);
        }
    }
}
