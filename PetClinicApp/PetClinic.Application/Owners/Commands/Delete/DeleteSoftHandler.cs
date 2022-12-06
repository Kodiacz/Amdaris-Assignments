namespace PetClinic.Application.Owners.Commands.Delete
{
    public class DeleteSoftHandler : IRequestHandler<DeleteSoft, Owner>
    {
        private readonly IUnitOfWork unitOfWorkRepo;

        public DeleteSoftHandler(IUnitOfWork unitOfWorkRepo)
        {
            this.unitOfWorkRepo = unitOfWorkRepo;
        }

        public async Task<Owner> Handle(DeleteSoft request, CancellationToken cancellationToken)
        {
            Owner owner = await this.unitOfWorkRepo.OwnerRepository.GetByIdAsync(request.Id);

            if (!owner.IsDeleted)
            {
                owner.IsDeleted = true;
            }
            else
            {
                throw new AlreadyDeletedException("This Owner is already deleted");
            }

            return owner;
        }
    }
}
