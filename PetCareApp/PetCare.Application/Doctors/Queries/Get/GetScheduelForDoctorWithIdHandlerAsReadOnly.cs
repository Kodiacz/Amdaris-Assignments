namespace PetCare.Application.Doctors.Queries.Get
{
    public class GetScheduelForDoctorWithIdAsReadonlyHandler : IRequestHandler<GetScheduelForDoctorWithIdAsReadOnly, Schedule>
    {
        private readonly IUnitOfWork repo;

        public GetScheduelForDoctorWithIdAsReadonlyHandler(IUnitOfWork repo)
        {
            this.repo = repo;
        }

        public async Task<Schedule> Handle(GetScheduelForDoctorWithIdAsReadOnly request, CancellationToken cancellationToken)
        {
            return await repo.DoctorRepository.GetSchedulesForDoctorReadonlyAsync(request.scheduleId);
        }
    }
}
