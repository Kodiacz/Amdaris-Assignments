namespace PetClinic.Application.Owners.Queries.Get
{
    public class GetAllOwnersHandler : IRequestHandler<GetAllOwners, List<Owner>>
    {
        private readonly IUnitOfWork unitOfWorkRepo;

        public GetAllOwnersHandler(IUnitOfWork unitOfWorkRepo)
        {
            this.unitOfWorkRepo = unitOfWorkRepo;
        }

        public async Task<List<Owner>> Handle(GetAllOwners request, CancellationToken cancellationToken)
        {
            return await unitOfWorkRepo.OwnerRepository.GetAllAsync();
        }
    }
}
