namespace PetCare.Application.Doctors.Queries.Get
{
    public class GetScheduelForDoctorWithIdHandler : IRequestHandler<GetScheduelForDoctorWithId, List<Schedule>>
    {
        private readonly IUnitOfWork repo;

        public GetScheduelForDoctorWithIdHandler(IUnitOfWork repo)
        {
            this.repo = repo;
        }

        public async Task<List<Schedule>> Handle(GetScheduelForDoctorWithId request, CancellationToken cancellationToken)
        {
            return await repo.DoctorRepository.GetSchedulesForDoctorAsync(request.DoctorId);
        }
    }
}
