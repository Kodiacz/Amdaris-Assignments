namespace PetCare.Application.Doctors.Commands.PartialUpdate
{
    public class PartialUpdateDoctorHandler : IRequestHandler<PartialUpdateDoctor, Doctor>
    {
        private readonly IUnitOfWork unitOfWork;

        public PartialUpdateDoctorHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Doctor> Handle(PartialUpdateDoctor request, CancellationToken cancellationToken)
        {
            Doctor doctor = new()
            {
                Id = request.Id,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Age = request.Age,
                Phonenumber = request.Phonenumber,
                JobDescription = request.JobDescription,
                StartedJobDate = request.StartedJobDate,
            };

            this.unitOfWork.DoctorRepository.Update(doctor);
            await this.unitOfWork.SaveAsync();

            return doctor;

        }
    }
}
