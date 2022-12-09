namespace PetClinic.Application.Doctors.Commands.Create
{
    public class CreateDoctorHandler : IRequestHandler<CreateDoctor, Doctor>
    {
        private readonly IUnitOfWork unitOfWorkRepo;

        public CreateDoctorHandler(IUnitOfWork unitOfWorkRepo)
        {
            this.unitOfWorkRepo = unitOfWorkRepo;
        }

        public async Task<Doctor> Handle(CreateDoctor request, CancellationToken cancellationToken)
        {
            var doctor = new Doctor
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Age = request.Age,
                JobDescription = request.JobDescription,
                StartedJobDate = request.StartedJobDate,
                Phonenumber = request.Phonenumber,
            };

            await this.unitOfWorkRepo.DoctorRepository.AddAsync(doctor);
            await this.unitOfWorkRepo.SaveAsync();

            return doctor;
        }
    }
}
