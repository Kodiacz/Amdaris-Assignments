namespace PetClinic.Application.Pets.Querires.Get
{
    public class GetAllPetsHandler : IRequestHandler<GetAllPets, List<Pet>>
    {
        private readonly IUnitOfWork unitOfWorkRepo;

        public GetAllPetsHandler(IUnitOfWork unitOfWorkRepo)
        {
            this.unitOfWorkRepo = unitOfWorkRepo;
        }

        public async Task<List<Pet>> Handle(GetAllPets request, CancellationToken cancellationToken)
        {
            return await unitOfWorkRepo.PetRepository.GetAllAsync();
        }
    }
}
