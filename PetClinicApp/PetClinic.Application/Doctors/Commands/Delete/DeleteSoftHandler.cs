namespace PetClinic.Application.Doctors.Commands.Delete
{
    using System.Threading;
    using System.Threading.Tasks;

    using MediatR;
    using PetClinic.Application.Exceptions;
    using PetClinic.Application.Interfaces;
    using PetClinic.Domain.Entities;

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
                doctor.IsDeleted = false;
            }
            else
            {
                throw new AlreadyDeletedException("This entity is already deleted");
            }

            return doctor;
        }
    }
}
