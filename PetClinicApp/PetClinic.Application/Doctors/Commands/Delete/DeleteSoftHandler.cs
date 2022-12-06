namespace PetClinic.Application.Doctors.Commands.Delete
{
    public class DeleteSoftHandler : IRequestHandler<DeleteSoft, Doctor>
    {
        private readonly IUnitOfWork uniteOfWorkRepo;

        public DeleteSoftHandler(IUnitOfWork uniteOfWorkRepo)
        {
            this.uniteOfWorkRepo = uniteOfWorkRepo;
        }

        public async Task<Doctor> Handle(DeleteSoft request, CancellationToken cancellationToken)
        {
            var doctor = await this.uniteOfWorkRepo.DoctorRepository.GetByIdAsync(request.Id);

            if (!doctor.IsDeleted)
            {
                doctor.IsDeleted = true;
            }
            else
            {
                throw new AlreadyDeletedException("This entity is already deleted");
            }

            return doctor;
        }
    }
}
