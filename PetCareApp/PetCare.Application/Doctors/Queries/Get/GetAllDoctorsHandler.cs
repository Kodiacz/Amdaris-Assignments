namespace PetCare.Application.Doctors.Queries.Get
{
    public class GetAllDoctorsHandler : IRequestHandler<GetAllDoctors, List<Doctor>>
    {
        private readonly IUnitOfWork unitOfWorkRepo;

        public GetAllDoctorsHandler(IUnitOfWork unitOfWorkRepo)
        {
            this.unitOfWorkRepo = unitOfWorkRepo;
        }

        public async Task<List<Doctor>> Handle(GetAllDoctors request, CancellationToken cancellationToken)
        {
            return await this.unitOfWorkRepo.DoctorRepository.GetAllAsync();
        }
    }
}
