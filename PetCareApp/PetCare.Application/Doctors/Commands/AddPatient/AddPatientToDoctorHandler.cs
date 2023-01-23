namespace PetCare.Application.Doctors.Commands.AddPatient
{
    public class AddPatientToDoctorHandler : IRequestHandler<AddPatientToDoctor, Pet>
    {
        private readonly IUnitOfWork unitOfWorkRepo;

        public AddPatientToDoctorHandler(IUnitOfWork unitOfWorkRepo)
        {
            this.unitOfWorkRepo = unitOfWorkRepo;
        }

        public async Task<Pet> Handle(AddPatientToDoctor request, CancellationToken cancellationToken)
        {
            Pet pet = await this.unitOfWorkRepo.PetRepository.GetByIdAsync(request.PatientId) ??
                throw new ArgumentNullException($"The pet with Id {request.PatientId} does not exist in the database");

            pet.DoctorId = request.DoctorId;

            await this.unitOfWorkRepo.DoctorRepository.AddPatient(pet, request.DoctorId);
            await this.unitOfWorkRepo.SaveAsync();

            return pet;
        }
    }
}
