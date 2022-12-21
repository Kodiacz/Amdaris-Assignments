namespace PetCare.Application.Owners.Queries.Get
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
            var testc =  await this.unitOfWork
                             .PetRepository
                             .GetAllAsync(p => !p.IsDeleted && p.OwnerId == request.OwnerId) 
                             ?? throw new ArgumentNullException($"The {nameof(Owner)} with {request.OwnerId} Id does not exist");

            return testc;
        }
    }
}
