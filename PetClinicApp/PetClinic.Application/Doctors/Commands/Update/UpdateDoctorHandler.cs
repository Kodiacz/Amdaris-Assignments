namespace PetClinic.Application.Doctors.Commands.Update
{
    public class UpdateDoctorHandler : IRequestHandler<UpdateDoctor, Doctor>
    {
        private readonly IUnitOfWork uniteOfWorkRepo;

        public UpdateDoctorHandler(IUnitOfWork uniteOfWorkRepo)
        {
            this.uniteOfWorkRepo = uniteOfWorkRepo;
        }

        public async Task<Doctor> Handle(UpdateDoctor request, CancellationToken cancellationToken)
        {
            var doctor = new Doctor
            {
                Id = request.Id,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Age = request.Age,
                JobDescription = request.JobDescription,
                StartedJobDate = request.StartedJobDate,
                Phonenumber = request.Phonenumber,
            };

            await this.uniteOfWorkRepo.DoctorRepository.UpdateAsync(doctor);
            await this.uniteOfWorkRepo.SaveAsync();

            return doctor;
        }
    }
}
