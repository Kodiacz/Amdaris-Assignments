namespace PetCare.Application.Appointments.Commands.Create
{
    public class CreateAppointmenHandler : IRequestHandler<CreateAppointmen, Appointment>
    {
        private readonly IUnitOfWork unitOfWorkRepo;

        public CreateAppointmenHandler(IUnitOfWork repo)
        {
            this.unitOfWorkRepo = repo;
        }

        public async Task<Appointment> Handle(CreateAppointmen request, CancellationToken cancellationToken)
        {
            if (await this.unitOfWorkRepo.OwnerRepository.GetByIdAsync(request.OwnerId) == null)
            {
                throw new NotExistException($"{nameof(Owner)} with {request.OwnerId} ID doest not exist in the database");
            }

            Appointment appointment = new()
            {
                DateOfAppointment = request.DateOfAppointment,
                ReasonForAppointment = request.ReasonForAppointment,
                PetName = request.PetName,
                DoctorFullName = request.DoctorFullName,
                OwnerId = request.OwnerId,
            };

            await this.unitOfWorkRepo.AppointmentRepository.AddAsync(appointment);
            await this.unitOfWorkRepo.SaveAsync();

            return appointment;
        }
    }
}
