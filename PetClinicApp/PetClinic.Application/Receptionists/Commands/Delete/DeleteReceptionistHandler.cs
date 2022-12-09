namespace PetClinic.Application.Receptionists.Commands.Delete
{
    public class DeleteReceptionistHandler : IRequestHandler<DeleteReceptionist, Receptionist>
    {
        private readonly IUnitOfWork unitOfWorkRepo;

        public DeleteReceptionistHandler(IUnitOfWork unitOfWorkRepo)
        {
            this.unitOfWorkRepo = unitOfWorkRepo;
        }

        public async Task<Receptionist> Handle(DeleteReceptionist request, CancellationToken cancellationToken)
        {
            Receptionist receptionist = await this.unitOfWorkRepo.ReceptionistRepository.GetByIdAsync(request.Id);

            if (!receptionist.IsDeleted)
            {
                receptionist.IsDeleted = true;
            }
            else
            {
                throw new AlreadyDeletedException("This Receptionist is already deleted");
            }

            await this.unitOfWorkRepo.SaveAsync();

            return receptionist;
        }
    }
}
