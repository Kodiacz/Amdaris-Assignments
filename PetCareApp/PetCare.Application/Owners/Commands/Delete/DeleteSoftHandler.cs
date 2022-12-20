namespace PetCare.Application.Owners.Commands.Delete
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

            if (!owner?.IsDeleted ?? false)
            {
                owner!.IsDeleted = true;
            }
            else
            {
                throw new AlreadyDeletedException($"The {nameof(Owner)} with Id {request.Id} is already deleted");
            }

            await this.unitOfWorkRepo.SaveAsync();

            return owner;
        }
    }
}
