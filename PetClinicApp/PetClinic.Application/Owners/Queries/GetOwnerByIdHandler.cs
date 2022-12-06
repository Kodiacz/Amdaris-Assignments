namespace PetClinic.Application.Owners.Queries
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
            return await this.unitOfWorkRepo.OwnerRepository.GetByIdAsync(request.Id);
        }
    }
}
