namespace PetClinic.Application.Owners.Queries.Get
{
    public class GetAllOwnerPetsHandler : IRequestHandler<GetAllOwnerPets, List<Pet>>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetAllOwnerPetsHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<List<Pet>> Handle(GetAllOwnerPets request, CancellationToken cancellationToken)
        {
            return await this.unitOfWork
                             .PetRepository
                             .GetAllAsync(p => !p.IsDeleted && p.OwnerId == request.OwnerId);

        }
    }
}
