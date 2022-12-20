namespace PetCare.Application.Doctors.Queries.Get
{
    public class GetDoctorByIdHandler : IRequestHandler<GetDoctorById, Doctor>
    {
        private readonly IUnitOfWork unitOfWorkRepo;

        public GetDoctorByIdHandler(IUnitOfWork unitOfWorkRepo)
        {
            this.unitOfWorkRepo = unitOfWorkRepo;
        }

        public async Task<Doctor> Handle(GetDoctorById request, CancellationToken cancellationToken)
        {
            return await this.unitOfWorkRepo.DoctorRepository.GetByIdAsync(request.Id)
                ?? throw new ArgumentNullException($"The {nameof(Doctor)} with Id {request.Id} does not exist"); ;
        }
    }
}
