namespace PetCare.Application.Owners.Queries.Get
{
    public class GetOwnerByIdHandler : IRequestHandler<GetOwnerById, Owner>
    {
        private readonly IUnitOfWork unitOfWorkRepo;

        public GetOwnerByIdHandler(IUnitOfWork unitOfWorkRepo)
        {
            this.unitOfWorkRepo = unitOfWorkRepo;
        }

        public async Task<Owner> Handle(GetOwnerById request, CancellationToken cancellationToken)
        {
            return await unitOfWorkRepo.OwnerRepository.GetByIdAsync(request.Id) 
                ?? throw new ArgumentNullException($"The {nameof(Owner)} with Id {request.Id} does not exist");
        }
    }
}
