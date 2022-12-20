namespace PetCare.Application.Doctors.Commands.Delete
{
    public class DeleteSoftHandler : IRequestHandler<DeleteSoft, Doctor>
    {
        private readonly IUnitOfWork unitOfWorkRepo;

        public DeleteSoftHandler(IUnitOfWork uniteOfWorkRepo)
        {
            this.unitOfWorkRepo = uniteOfWorkRepo;
        }

        public async Task<Doctor> Handle(DeleteSoft request, CancellationToken cancellationToken)
        {
            var doctor = await this.unitOfWorkRepo.DoctorRepository.GetByIdAsync(request.Id);

            if (!doctor?.IsDeleted ?? false)
            {
                doctor!.IsDeleted = true;
            }
            else
            {
                throw new AlreadyDeletedException($"The {nameof(Doctor)} with Id {request.Id} is already deleted");
            }

            await this.unitOfWorkRepo.SaveAsync();

            return doctor;
        }
    }
}
