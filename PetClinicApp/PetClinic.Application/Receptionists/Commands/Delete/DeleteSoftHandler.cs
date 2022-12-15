namespace PetClinic.Application.Receptionists.Commands.Delete
{
    public class DeleteSoftHandler : IRequestHandler<DeleteSoft, Receptionist>
    {
        private readonly IUnitOfWork unitOfWorkRepo;

        public DeleteSoftHandler(IUnitOfWork unitOfWorkRepo)
        {
            this.unitOfWorkRepo = unitOfWorkRepo;
        }

        public async Task<Receptionist> Handle(DeleteSoft request, CancellationToken cancellationToken)
        {
            Receptionist receptionist = await this.unitOfWorkRepo.ReceptionistRepository.GetByIdAsync(request.Id);

            if (!receptionist.IsDeleted)
            {
                receptionist.IsDeleted = true;
            }
            else
            {
                throw new AlreadyDeletedException($"The ${nameof(Receptionist)} with Id ${request.Id} is already deleted");
            }

            await this.unitOfWorkRepo.SaveAsync();

            return receptionist;
        }
    }
}
